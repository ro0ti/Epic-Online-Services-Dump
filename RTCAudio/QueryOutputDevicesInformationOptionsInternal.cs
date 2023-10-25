using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	internal struct QueryOutputDevicesInformationOptionsInternal : ISettable<QueryOutputDevicesInformationOptions>, IDisposable
	{
		// Token: 0x06000E89 RID: 3721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref QueryOutputDevicesInformationOptions other)
		{
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x4E0380", Offset = "0x4DE980", VA = "0x1804E0380", Slot = "5")]
		public void Set(ref QueryOutputDevicesInformationOptions? other)
		{
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
