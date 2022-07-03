
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ObjectSystem]
	public class Scroll_Item_serverTestDestroySystem : DestroySystem<Scroll_Item_serverTest> 
	{
		public override void Destroy( Scroll_Item_serverTest self )
		{
			self.DestroyWidget();
		}
	}
}
