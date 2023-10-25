using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	internal struct GetLocalPlatformTypeOptionsInternal : ISettable<GetLocalPlatformTypeOptions>, IDisposable
	{
		// Token: 0x060003FB RID: 1019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetLocalPlatformTypeOptions other)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x4A6620", Offset = "0x4A4C20", VA = "0x1804A6620", Slot = "5")]
		public void Set(ref GetLocalPlatformTypeOptions? other)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
