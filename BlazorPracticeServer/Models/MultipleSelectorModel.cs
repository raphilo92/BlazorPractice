﻿namespace BlazorPracticeServer.Models
{
    public class MultipleSelectorModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public bool Selectable { get; set; }

        public MultipleSelectorModel(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
