using System.Collections.Generic;

namespace ET.Client
{
	[ComponentOf(typeof(UIBaseWindow))]
	public  class DlgLobby :Entity,IAwake,IDestroy,IUILogic
	{

		public DlgLobbyViewComponent View { get => this.Parent.GetComponent<DlgLobbyViewComponent>();}

	

	}
}
