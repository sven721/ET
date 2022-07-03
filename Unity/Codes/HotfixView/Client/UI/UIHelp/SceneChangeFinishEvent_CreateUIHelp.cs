using ET.EventType;

namespace ET.Client
{
    [Event(SceneType.Client)]//AEventAsync
    public class SceneChangeFinishEvent_CreateUIHelp : AEvent<Scene, EventType.SceneChangeFinish>
    {
        // protected override async ETTask Run(EventType.SceneChangeFinish args)
        // {
        //     await args.CurrentScene.GetComponent<UIComponent>().ShowWindowAsync(WindowID.WindowID_Helper);
        // }
        protected override async ETTask Run(Scene entity, SceneChangeFinish a)
        {
           await entity.GetComponent<UIComponent>().ShowWindowAsync(WindowID.WindowID_Helper);
        }
    }
}
