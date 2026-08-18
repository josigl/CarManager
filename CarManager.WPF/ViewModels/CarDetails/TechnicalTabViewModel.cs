using CarManager.Core.Models;
using CarManager.Core.Utilities;
using CarManager.Core.Enums;

namespace CarManager.WPF.ViewModels.CarDetails
{
    public class TechnicalTabViewModel
    {
        public TechnicalTabViewModel(CarTechnicalData technicalData)
        {
            TechnicalData = technicalData;
        }

        public CarTechnicalData TechnicalData { get; init; }

        public int PowerHp => UnitConverter.KwToHp(TechnicalData.PowerKw);

        public bool IsCombustion => TechnicalData.PowerTrain == CarPowerTrain.ICE;
        public bool IsElectric => TechnicalData.PowerTrain == CarPowerTrain.BEV;
        public bool IsHybrid => TechnicalData.PowerTrain is CarPowerTrain.MHEV or CarPowerTrain.HEV;
        public bool IsPlugInHybrid => TechnicalData.PowerTrain == CarPowerTrain.PHEV;

    }
}
