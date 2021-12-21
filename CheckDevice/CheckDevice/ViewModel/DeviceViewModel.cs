using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace CheckDevice.ViewModel
{
    public class DeviceViewModel : BaseViewModel
    {
        public DeviceViewModel()
        {
            Device = DeviceInfo.Model;
            ManuFacturer = DeviceInfo.Manufacturer;
            DeviceName = DeviceInfo.Name;
            DeviceType = DeviceInfo.DeviceType.ToString();
            Platform = DeviceInfo.Platform.ToString();
            
        }

        private string device;
        public string Device
        {
            get => device;
            set => SetProperty(ref device, value);
        }

        private string deviceType;
        public string DeviceType
        {
            get => deviceType;
            set => SetProperty(ref deviceType, value);
        }

        private string manuFacturer;
        public string ManuFacturer
        {
            get => manuFacturer;
            set => SetProperty(ref manuFacturer, value);
        }


        private string deviceName;
        public string DeviceName
        {
            get => deviceName;
            set => SetProperty(ref deviceName, value);
        }

        private string platform;
        public string Platform
        {
            get => platform;
            set => SetProperty(ref platform, value);
        }
    }

    

}
