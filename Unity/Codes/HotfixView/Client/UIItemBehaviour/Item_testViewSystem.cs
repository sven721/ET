
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ObjectSystem]
	public class Scroll_Item_testDestroySystem : DestroySystem<Scroll_Item_test> 
	{
		public override void Destroy( Scroll_Item_test self )
		{
			self.DestroyWidget();
		}
	}
}
