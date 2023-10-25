using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004B5 RID: 1205
	[Token(Token = "0x20004B5")]
	internal struct GetPermissionsCountOptionsInternal : ISettable<GetPermissionsCountOptions>, IDisposable
	{
		// Token: 0x170008CC RID: 2252
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008CC")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001F05")]
			[Address(RVA = "0x524090", Offset = "0x522690", VA = "0x180524090")]
			set
			{
			}
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F06")]
		[Address(RVA = "0x523F90", Offset = "0x522590", VA = "0x180523F90", Slot = "4")]
		public void Set(ref GetPermissionsCountOptions other)
		{
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F07")]
		[Address(RVA = "0x523FF0", Offset = "0x5225F0", VA = "0x180523FF0", Slot = "5")]
		public void Set(ref GetPermissionsCountOptions? other)
		{
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F08")]
		[Address(RVA = "0x523F40", Offset = "0x522540", VA = "0x180523F40", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000DC4 RID: 3524
		[Token(Token = "0x4000DC4")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000DC5 RID: 3525
		[Token(Token = "0x4000DC5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
