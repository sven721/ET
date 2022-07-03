using ET.EventType;

namespace ET.Client
{
    [Event(SceneType.Client)]//AEventAsync
    public class LoginFinish_CreateLobbyUI: AEvent<Scene, EventType.LoginFinish>
    {
        /*protected override async ETTask Run(EventType.LoginFinish args)
        {
            args.ZoneScene.GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Login);
            await args.ZoneScene.GetComponent<UIComponent>().ShowWindowAsync(WindowID.WindowID_Lobby);
        }*/

        protected override async ETTask Run(Scene entity, LoginFinish a)
        {
            entity.GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Login);
            await entity.GetComponent<UIComponent>().ShowWindowAsync(WindowID.WindowID_Lobby);
        }
    }
}