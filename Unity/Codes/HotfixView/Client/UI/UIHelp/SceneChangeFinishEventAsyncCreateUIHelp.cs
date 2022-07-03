using ET.EventType;

namespace ET.Client
{
    [Event(SceneType.Client)]//AEventAsync
    public class SceneChangeFinishEventAsyncCreateUIHelp : AEvent<Scene, EventType.SceneChangeFinish>
    {
        // protected override async ETTask Run(EventType.SceneChangeFinish args)
        // {
        //     //UIHelper.Create(args.CurrentScene, UIType.UIHelp, UILayer.Mid).Coroutine();
        //     await ETTask.CompletedTask;
        // }

        protected override async ETTask Run(Scene entity, SceneChangeFinish a)
        {
            await ETTask.CompletedTask;
        }
    }
}
