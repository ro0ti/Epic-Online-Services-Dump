using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002FA RID: 762
	// (Invoke) Token: 0x06001488 RID: 5256
	[Token(Token = "0x20002FA")]
	public delegate void OnWriteFileCompleteCallback(ref WriteFileCallbackInfo data);
}
