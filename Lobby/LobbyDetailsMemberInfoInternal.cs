using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003FA RID: 1018
	[Token(Token = "0x20003FA")]
	internal struct LobbyDetailsMemberInfoInternal : IGettable<LobbyDetailsMemberInfo>, ISettable<LobbyDetailsMemberInfo>, IDisposable
	{
		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007A2")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6001AC0")]
			[Address(RVA = "0x513340", Offset = "0x511940", VA = "0x180513340")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AC1")]
			[Address(RVA = "0x513420", Offset = "0x511A20", VA = "0x180513420")]
			set
			{
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x00007844 File Offset: 0x00005A44
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007A3")]
		public uint Platform
		{
			[Token(Token = "0x6001AC2")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001AC3")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0000785C File Offset: 0x00005A5C
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007A4")]
		public bool AllowsCrossplay
		{
			[Token(Token = "0x6001AC4")]
			[Address(RVA = "0x5132E0", Offset = "0x5118E0", VA = "0x1805132E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AC5")]
			[Address(RVA = "0x5133C0", Offset = "0x5119C0", VA = "0x1805133C0")]
			set
			{
			}
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AC6")]
		[Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210", Slot = "5")]
		public void Set(ref LobbyDetailsMemberInfo other)
		{
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AC7")]
		[Address(RVA = "0x5130E0", Offset = "0x5116E0", VA = "0x1805130E0", Slot = "6")]
		public void Set(ref LobbyDetailsMemberInfo? other)
		{
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AC8")]
		[Address(RVA = "0x513070", Offset = "0x511670", VA = "0x180513070", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0x5130C0", Offset = "0x5116C0", VA = "0x1805130C0", Slot = "4")]
		public void Get(out LobbyDetailsMemberInfo output)
		{
		}

		// Token: 0x04000C18 RID: 3096
		[Token(Token = "0x4000C18")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000C19 RID: 3097
		[Token(Token = "0x4000C19")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;

		// Token: 0x04000C1A RID: 3098
		[Token(Token = "0x4000C1A")]
		[FieldOffset(Offset = "0x10")]
		private uint m_Platform;

		// Token: 0x04000C1B RID: 3099
		[Token(Token = "0x4000C1B")]
		[FieldOffset(Offset = "0x14")]
		private int m_AllowsCrossplay;
	}
}
