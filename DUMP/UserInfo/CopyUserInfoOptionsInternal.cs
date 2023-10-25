using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	internal struct CopyUserInfoOptionsInternal : ISettable<CopyUserInfoOptions>, IDisposable
	{
		// Token: 0x17000043 RID: 67
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000043")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x4A15E0", Offset = "0x49FBE0", VA = "0x1804A15E0")]
			set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000044")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x4A1690", Offset = "0x49FC90", VA = "0x1804A1690")]
			set
			{
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x4A15A0", Offset = "0x49FBA0", VA = "0x1804A15A0", Slot = "4")]
		public void Set(ref CopyUserInfoOptions other)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x4A1500", Offset = "0x49FB00", VA = "0x1804A1500", Slot = "5")]
		public void Set(ref CopyUserInfoOptions? other)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x4A1420", Offset = "0x49FA20", VA = "0x1804A1420", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
