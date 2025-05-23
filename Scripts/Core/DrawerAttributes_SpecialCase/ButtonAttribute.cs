using System;

namespace NaughtyAttributes
{
    public enum EButtonEnableMode
    {
        /// <summary>
        /// Button should be active always
        /// </summary>
        Always,
        /// <summary>
        /// Button should be active only in editor
        /// </summary>
        Editor,
        /// <summary>
        /// Button should be active only in playmode
        /// </summary>
        Playmode
    }

    public enum EButtonStyle
    {
        Default,
        Red,
        Green,
        Orange
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class ButtonAttribute : SpecialCaseDrawerAttribute
    {
        public string Text { get; private set; }
        public EButtonEnableMode SelectedEnableMode { get; private set; }

        public EButtonStyle ButtonStyle { get; private set; } = EButtonStyle.Default;

        public ButtonAttribute(string text = null, EButtonEnableMode enabledMode = EButtonEnableMode.Always, EButtonStyle buttonStyle = EButtonStyle.Default)
        {
            this.Text = text;
            this.SelectedEnableMode = enabledMode;
            this.ButtonStyle = buttonStyle;
        }
    }
}
