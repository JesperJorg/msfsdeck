﻿namespace Loupedeck.MsfsPlugin.folder
{
    using System;

    public class LightsMultiInputs : PluginDynamicCommand, Notifiable
    {
        protected readonly String _imageOffResourcePath = "Loupedeck.MsfsPlugin.Resources.off.png";
        protected readonly String _imageOnResourcePath = "Loupedeck.MsfsPlugin.Resources.on.png";

        public LightsMultiInputs() : base()
        {

            this.AddParameter("Navigation", "Navigation light", "Lights");
            this.AddParameter("Beacon", "Beacon light", "Lights");
            this.AddParameter("Landing", "Landing light", "Lights");
            this.AddParameter("Taxi", "Taxi light", "Lights");
            this.AddParameter("Strobes", "Strobes light", "Lights");
            this.AddParameter("Instruments", "Instruments light", "Lights");
            this.AddParameter("Recognition", "Recognition light", "Lights");
            this.AddParameter("Wing", "Wing light", "Lights");
            this.AddParameter("Logo", "Logo light", "Lights");
            this.AddParameter("Cabin", "Cabin light", "Lights");

            MsfsData.Instance.Register(this);

        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            var bitmapBuilder = new BitmapBuilder(imageSize);
            switch (actionParameter)
            {
                case "Navigation":
                    bitmapBuilder.SetBackgroundImage(MsfsData.Instance.NavigationLightState ? EmbeddedResources.ReadImage(this._imageOnResourcePath) : EmbeddedResources.ReadImage(this._imageOffResourcePath));
                    break;
                case "Beacon":
                    bitmapBuilder.SetBackgroundImage(MsfsData.Instance.BeaconLightState ? EmbeddedResources.ReadImage(this._imageOnResourcePath) : EmbeddedResources.ReadImage(this._imageOffResourcePath));
                    break;
                case "Landing":
                    bitmapBuilder.SetBackgroundImage(MsfsData.Instance.LandingLightState ? EmbeddedResources.ReadImage(this._imageOnResourcePath) : EmbeddedResources.ReadImage(this._imageOffResourcePath));
                    break;
                case "Taxi":
                    bitmapBuilder.SetBackgroundImage(MsfsData.Instance.TaxiLightState ? EmbeddedResources.ReadImage(this._imageOnResourcePath) : EmbeddedResources.ReadImage(this._imageOffResourcePath));
                    break;
                case "Strobes":
                    bitmapBuilder.SetBackgroundImage(MsfsData.Instance.StrobesLightState ? EmbeddedResources.ReadImage(this._imageOnResourcePath) : EmbeddedResources.ReadImage(this._imageOffResourcePath));
                    break;
                case "Instruments":
                    bitmapBuilder.SetBackgroundImage(MsfsData.Instance.InstrumentsLightState ? EmbeddedResources.ReadImage(this._imageOnResourcePath) : EmbeddedResources.ReadImage(this._imageOffResourcePath));
                    break;
                case "Recognition":
                    bitmapBuilder.SetBackgroundImage(MsfsData.Instance.RecognitionLightState ? EmbeddedResources.ReadImage(this._imageOnResourcePath) : EmbeddedResources.ReadImage(this._imageOffResourcePath));
                    break;
                case "Wing":
                    bitmapBuilder.SetBackgroundImage(MsfsData.Instance.WingLightState ? EmbeddedResources.ReadImage(this._imageOnResourcePath) : EmbeddedResources.ReadImage(this._imageOffResourcePath));
                    break;
                case "Logo":
                    bitmapBuilder.SetBackgroundImage(MsfsData.Instance.LogoLightState ? EmbeddedResources.ReadImage(this._imageOnResourcePath) : EmbeddedResources.ReadImage(this._imageOffResourcePath));
                    break;
                case "Cabin":
                    bitmapBuilder.SetBackgroundImage(MsfsData.Instance.CabinLightState ? EmbeddedResources.ReadImage(this._imageOnResourcePath) : EmbeddedResources.ReadImage(this._imageOffResourcePath));
                    break;
            }
            bitmapBuilder.DrawText(actionParameter);
            return bitmapBuilder.ToImage();
        }
        protected override void RunCommand(String actionParameter)
        {
            switch (actionParameter)
            {
                case "Navigation":
                    MsfsData.Instance.NavigationLight = !MsfsData.Instance.NavigationLight;
                    break;
                case "Beacon":
                    MsfsData.Instance.BeaconLight = !MsfsData.Instance.BeaconLight;
                    break;
                case "Landing":
                    MsfsData.Instance.LandingLight = !MsfsData.Instance.LandingLight;
                    break;
                case "Taxi":
                    MsfsData.Instance.TaxiLight = !MsfsData.Instance.TaxiLight;
                    break;
                case "Strobes":
                    MsfsData.Instance.StrobesLight = !MsfsData.Instance.StrobesLight;
                    break;
                case "Instruments":
                    MsfsData.Instance.InstrumentsLight = !MsfsData.Instance.InstrumentsLight;
                    break;
                case "Recognition":
                    MsfsData.Instance.RecognitionLight = !MsfsData.Instance.RecognitionLight;
                    break;
                case "Wing":
                    MsfsData.Instance.WingLight = !MsfsData.Instance.WingLight;
                    break;
                case "Logo":
                    MsfsData.Instance.LogoLight = !MsfsData.Instance.LogoLight;
                    break;
                case "Cabin":
                    MsfsData.Instance.CabinLight = !MsfsData.Instance.CabinLight;
                    break;
            }
        }
        public void Notify() { if (!MsfsData.Instance.folderDisplayed) { this.ActionImageChanged(); } }
    }

}
