using ET.EventType;

namespace ET.Client
{
    [Event(SceneType.Client)]//AEvent
    public class LoadingFinishEventAsyncRemoveLoadingUI : AEvent<Scene, EventType.LoadingFinish>
    {
        protected override async ETTask Run(Scene entity, LoadingFinish a)
        {
            await ETTask.CompletedTask;
            //UIHelper.Create(args.Scene, UIType.UILoading, UILayer.Mid).Coroutine();
        }
    }
}
