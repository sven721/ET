using ET.EventType;

namespace ET.Client
{
    
    [Event(SceneType.Client)]//AEventAsync
    public class SceneChangeFinish_ShowCurrentSceneUI: AEvent<Scene, EventType.SceneChangeFinish>
    {
        // protected override async ETTask Run(EventType.SceneChangeFinish args)
        // {
        //     args.ZoneScene.GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Lobby);
        //     await ETTask.CompletedTask;
        // }

        protected override async ETTask Run(Scene entity, SceneChangeFinish a)
        {
            entity.GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Lobby);
            await ETTask.CompletedTask;
        }
    }
    
}