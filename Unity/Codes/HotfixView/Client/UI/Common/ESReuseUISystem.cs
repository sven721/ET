namespace ET.Client
{
    public static class ESReuseUISystem
    {
        public static void TestFunction(this ESReuseUI self,string content)
        {
            self.ELabel_testText.text = content;
        }
    }
}