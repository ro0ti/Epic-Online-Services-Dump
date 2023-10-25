using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	internal struct BestDisplayNameInternal : IGettable<BestDisplayName>, ISettable<BestDisplayName>, IDisposable
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600038D RID: 909 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000020")]
		public EpicAccountId UserId
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x487DC0", Offset = "0x4863C0", VA = "0x180487DC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x487F60", Offset = "0x486560", VA = "0x180487F60")]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600038F RID: 911 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000021")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x487CE0", Offset = "0x4862E0", VA = "0x180487CE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x487EA0", Offset = "0x4864A0", VA = "0x180487EA0")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000391 RID: 913 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000022")]
		public Utf8String DisplayNameSanitized
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x487C70", Offset = "0x486270", VA = "0x180487C70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x487E40", Offset = "0x486440", VA = "0x180487E40")]
			set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000393 RID: 915 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000023")]
		public Utf8String Nickname
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x487D50", Offset = "0x486350", VA = "0x180487D50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x487F00", Offset = "0x486500", VA = "0x180487F00")]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000395 RID: 917 RVA: 0x000025F4 File Offset: 0x000007F4
		// (set) Token: 0x06000396 RID: 918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000024")]
		public uint PlatformType
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x3D2E70", Offset = "0x3D1470", VA = "0x1803D2E70")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x3D2EA0", Offset = "0x3D14A0", VA = "0x1803D2EA0")]
			set
			{
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x4879B0", Offset = "0x485FB0", VA = "0x1804879B0", Slot = "5")]
		public void Set(ref BestDisplayName other)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x487AD0", Offset = "0x4860D0", VA = "0x180487AD0", Slot = "6")]
		public void Set(ref BestDisplayName? other)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x487810", Offset = "0x485E10", VA = "0x180487810", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x487980", Offset = "0x485F80", VA = "0x180487980", Slot = "4")]
		public void Get(out BestDisplayName output)
		{
		}

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_DisplayName;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_DisplayNameSanitized;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_Nickname;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x28")]
		private uint m_PlatformType;
	}
}
