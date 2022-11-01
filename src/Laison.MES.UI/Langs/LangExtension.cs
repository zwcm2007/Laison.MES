namespace Laison.MES.UI.Langs
{
    /// <summary>
    /// 多语言扩展标记
    /// </summary>
    public class LangExtension : HandyControl.Tools.Extension.LangExtension
    {
        public LangExtension()
        {
            Source = LangProvider.Instance;
        }
    }
}