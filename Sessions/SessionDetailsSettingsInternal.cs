using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	internal struct SessionDetailsSettingsInternal : IGettable<SessionDetailsSettings>, ISettable<SessionDetailsSettings>, IDisposable
	{
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000251")]
		public Utf8String BucketId
		{
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x4C85C0", Offset = "0x4C6BC0", VA = "0x1804C85C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x4C87D0", Offset = "0x4C6DD0", VA = "0x1804C87D0")]
			set
			{
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00003DDC File Offset: 0x00001FDC
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000252")]
		public uint NumPublicConnections
		{
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00003DF4 File Offset: 0x00001FF4
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000253")]
		public bool AllowJoinInProgress
		{
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x4C84D0", Offset = "0x4C6AD0", VA = "0x1804C84D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x4C86F0", Offset = "0x4C6CF0", VA = "0x1804C86F0")]
			set
			{
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00003E0C File Offset: 0x0000200C
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000254")]
		public OnlineSessionPermissionLevel PermissionLevel
		{
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return OnlineSessionPermissionLevel.PublicAdvertised;
			}
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00003E24 File Offset: 0x00002024
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000255")]
		public bool InvitesAllowed
		{
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x4C8630", Offset = "0x4C6C30", VA = "0x1804C8630")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x4C8830", Offset = "0x4C6E30", VA = "0x1804C8830")]
			set
			{
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00003E3C File Offset: 0x0000203C
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000256")]
		public bool SanctionsEnabled
		{
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x4C8690", Offset = "0x4C6C90", VA = "0x1804C8690")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x4C8890", Offset = "0x4C6E90", VA = "0x1804C8890")]
			set
			{
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000257")]
		public uint[] AllowedPlatformIds
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x4C8530", Offset = "0x4C6B30", VA = "0x1804C8530")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x4C8750", Offset = "0x4C6D50", VA = "0x1804C8750")]
			set
			{
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x4C8360", Offset = "0x4C6960", VA = "0x1804C8360", Slot = "5")]
		public void Set(ref SessionDetailsSettings other)
		{
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x4C8130", Offset = "0x4C6730", VA = "0x1804C8130", Slot = "6")]
		public void Set(ref SessionDetailsSettings? other)
		{
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x4C80B0", Offset = "0x4C66B0", VA = "0x1804C80B0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x4C8110", Offset = "0x4C6710", VA = "0x1804C8110", Slot = "4")]
		public void Get(out SessionDetailsSettings output)
		{
		}

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_BucketId;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x10")]
		private uint m_NumPublicConnections;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x14")]
		private int m_AllowJoinInProgress;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x18")]
		private OnlineSessionPermissionLevel m_PermissionLevel;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x1C")]
		private int m_InvitesAllowed;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x20")]
		private int m_SanctionsEnabled;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_AllowedPlatformIds;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x30")]
		private uint m_AllowedPlatformIdsCount;
	}
}
