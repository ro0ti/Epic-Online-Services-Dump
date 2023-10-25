using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002FC RID: 764
	// (Invoke) Token: 0x06001490 RID: 5264
	[Token(Token = "0x20002FC")]
	public delegate WriteResult OnWriteFileDataCallback(ref WriteFileDataCallbackInfo data, out ArraySegment<byte> outDataBuffer);
}
