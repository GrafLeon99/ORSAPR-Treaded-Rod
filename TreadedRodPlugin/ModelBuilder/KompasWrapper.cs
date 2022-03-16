using System;
using System.Runtime.InteropServices;
using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;

namespace Kompas
{
    /// <summary>
    /// Класс, реализующий различные построения в Компас-3D 
    /// </summary>
    public class KompasWrapper
    {
        /// <summary>
        /// Шаг резьбы по умолчанию
        /// </summary>
        private const double DEFAULT_TREAD_STEP = 1.0;

        /// <summary>
        /// Объект API КОМПАС-3D
        /// </summary>
        private KompasObject _kompasObject;

        /// <summary>
        /// Объект детали
        /// </summary>
        private ksPart _part;

        /// <summary>
        /// Подключиться к открытому компас-3D.
        /// </summary>
        private void ConnectKompass()
        {
            KompasObject kompas;
            try
            {
                kompas = (KompasObject)Marshal.GetActiveObject("KOMPAS.Application.5");
            }
            catch (COMException)
            {
                throw new ArgumentException
                    (
                    "Не обнаружен запущенный Компас-3D"
                    );
            }
            kompas.Visible = true;
            kompas.ActivateControllerAPI();
            _kompasObject = kompas;
        }

        /// <summary>
        /// Создать новую деталь в компас-3D
        /// </summary>
        private void CreateNewDetail()
        {
            ksDocument3D document3D = (ksDocument3D)_kompasObject.Document3D();
            document3D.Create();
            _part = (ksPart)document3D.GetPart((int)Part_Type.pTop_Part);
        }

        /// <summary>
        /// Создать новый эскиз
        /// </summary>
        /// <param name="planeType">Плоскость, в которой выполняется построение</param>
        /// <param name="offset">Смещение плоскости по оси</param>
        /// <returns cref="ksSketchDefinition">Объект свойств эскиза</returns>
        private ksSketchDefinition CreateSketch(Obj3dType planeType, double offset = 0)
        {
            var plan = (ksEntity)_part.GetDefaultEntity((short)planeType);
            var sketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            var sketchDefinition = (ksSketchDefinition)sketch.GetDefinition();
            sketchDefinition.SetPlane(plan);
            var offsetEntity = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_planeOffset);
            var offsetDef = (ksPlaneOffsetDefinition)offsetEntity
                .GetDefinition();
            offsetDef.SetPlane(plan);
            offsetDef.offset = offset;
            offsetDef.direction = true;
            offsetEntity.Create();
            sketchDefinition.SetPlane(offsetEntity);
            sketch.Create();
            return sketchDefinition;
        }

        /// <summary>
        /// Создать конструктивный элемент шпильки
        /// </summary>
        /// <param name="diameter">Диаметр</param>
        /// <param name="length">Длина</param>
        /// <param name="offset">Смещение по оси</param>
        /// <param name="isTreaded">Присутствует резьба</param>
        public void CreateElement(double diameter,
            double length, double offset,bool isTreaded = false)
        {
            Obj3dType horizontalPlane = Obj3dType.o3d_planeXOY;
            Obj3dType verticalPlane = Obj3dType.o3d_planeXOZ;
            ksSketchDefinition circle = CreateCircle(
                horizontalPlane, offset, diameter);
            ExtrudeCircle(circle, length);
            if (isTreaded)
            {
                ksSketchDefinition tread = CreateTread(
                    verticalPlane, offset, diameter, DEFAULT_TREAD_STEP);
                ksEntity spiral = CreateSpiral(circle, length, DEFAULT_TREAD_STEP);
                CutTread(tread, spiral);
            }
        }

        /// <summary>
        /// Создать эскиз окружности
        /// </summary>
        /// <param name="basePlane">Плоскость построения</param>
        /// <param name="offset">Смещение по оси</param>
        /// <param name="diameter">Диаметр</param>
        /// <returns cref="ksSketchDefinition">Объект свойств эскиза</returns>
        private ksSketchDefinition CreateCircle(Obj3dType basePlane, double offset, double diameter)
        {
            ksSketchDefinition sketch = CreateSketch(basePlane, offset);
            Document2D document2d = (Document2D)sketch.BeginEdit();
            document2d.ksCircle(0, 0, diameter / 2, 1);
            sketch.EndEdit();
            return sketch;
        }

        /// <summary>
        /// Создать эскиз сечения резьбы
        /// </summary>
        /// <param name="basePlane">Плоскость построения</param>
        /// <param name="offset">Смещение по оси</param>
        /// <param name="diameter">Диаметр резьбы</param>
        /// <param name="step">Шаг резьбы</param>
        /// <returns cref="ksSketchDefinition">Объект свойств эскиза</returns>
        private ksSketchDefinition CreateTread(Obj3dType basePlane, double offset, double diameter, double step)
        {
            ksSketchDefinition sketch = CreateSketch(basePlane);
            Document2D document2d = (Document2D)sketch.BeginEdit();

            double x = diameter / 2;
            double z = -offset;
            double treadSize = 1*step;
            document2d.ksLineSeg(x, z, x, z + treadSize, 1);
            document2d.ksLineSeg(x, z, x - treadSize, z + treadSize/2, 1);
            document2d.ksLineSeg(x, z + treadSize, x - treadSize, z + treadSize/2, 1);

            sketch.EndEdit();
            return sketch;
        }

        /// <summary>
        /// Создать объект спирали
        /// </summary>
        /// <param name="circle">Cвойства эскиза окружности</param>
        /// <param name="length">Длина</param>
        /// <param name="step">Шаг резьбы</param>
        /// <returns cref="ksEntity">Объект спирали</returns>
        private ksEntity CreateSpiral(ksSketchDefinition circle, double length, double step)
        {
            ksEntity conicSpiral =
                 (ksEntity)_part.NewEntity((short)Obj3dType.o3d_cylindricSpiral);
            ksCylindricSpiralDefinition cylindricalSpiralDefinition =
                (ksCylindricSpiralDefinition)conicSpiral.GetDefinition();
            cylindricalSpiralDefinition.buildDir = true;
            cylindricalSpiralDefinition.buildMode = 2;
            cylindricalSpiralDefinition.turn = 
                ((int)(length/step)) - 1;
            cylindricalSpiralDefinition.height = length;
            cylindricalSpiralDefinition.SetPlane(circle.GetPlane());
            conicSpiral.SetAdvancedColor(0);
            conicSpiral.hidden = true;
            conicSpiral.Create();
            return conicSpiral;
        }

        /// <summary>
        /// Вырезать резьбу
        /// </summary>
        /// <param name="sketch">Cвойства эскиза сечения</param>
        /// <param name="spiral">Объект спирали</param>
        private void CutTread(ksSketchDefinition sketch,ksEntity spiral)
        {
            ksEntity cinematicEvolition =
                (ksEntity)_part.NewEntity((short)Obj3dType.o3d_cutEvolution);
            ksCutEvolutionDefinition cutEvolutionDefinition =
                (ksCutEvolutionDefinition)cinematicEvolition.GetDefinition();
            cutEvolutionDefinition.SetSketch(sketch);
            ksEntityCollection collection =
                (ksEntityCollection)cutEvolutionDefinition.PathPartArray();
            collection.Add(spiral);
            cinematicEvolition.Create();
        }

        /// <summary>
        /// Выдавить цилиндр
        /// </summary>
        /// <param name="sketch">Cвойства эскиза окружности</param>
        /// <param name="length">Длина цилиндра</param>
        private void ExtrudeCircle( ksSketchDefinition sketch,double length)
        {
            var extrusionEntity = (ksEntity)_part.NewEntity(
                (short)ksObj3dTypeEnum.o3d_bossExtrusion);
            var extrusionDef = (ksBossExtrusionDefinition)extrusionEntity
                .GetDefinition();
            extrusionDef.SetSideParam(true, (short)End_Type.etBlind, length);
            extrusionDef.SetSketch(sketch);
            extrusionEntity.Create();
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public KompasWrapper() 
        {
            ConnectKompass();
            CreateNewDetail();
        }
    }
}
