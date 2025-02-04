﻿namespace CentralBankSDK.Model
{
    /// <summary>
    /// Информация со списком существующих валют.
    /// </summary>
    [Serializable]
    public sealed record ValuteData
    {
        /// <summary>
        /// Список существующих валют.
        /// </summary>
        [XmlElement(ElementName = "EnumValutes")]
        public List<EnumValutes> EnumValutes { get; init; } = default!;
    }
}
