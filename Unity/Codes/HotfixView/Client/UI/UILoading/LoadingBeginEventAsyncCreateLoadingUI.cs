using UnityEngine;

namespace ET.Client
{
    [Event(SceneType.Client)]//AEvent
    public class LoadingBeginEventAsyncCreateLoadingUI : AEvent<Scene, EventType.LoadingBegin>
    {
        protected override async ETTask Run(Scene scene, EventType.LoadingBegin args)
        {
            await ETTask.CompletedTask;
            //UIHelper.Create(args.Scene, UIType.UILoading, UILayer.Mid).Coroutine();
        }
    }
}
