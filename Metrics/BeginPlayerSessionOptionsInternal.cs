using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Metrics
{
	// Token: 0x02000382 RID: 898
	[Token(Token = "0x2000382")]
	internal struct BeginPlayerSessionOptionsInternal : ISettable<BeginPlayerSessionOptions>, IDisposable
	{
		// Token: 0x170006A4 RID: 1700
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006A4")]
		public BeginPlayerSessionOptionsAccountId AccountId
		{
			[Token(Token = "0x6001817")]
			[Address(RVA = "0x508260", Offset = "0x506860", VA = "0x180508260")]
			set
			{
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (set) Token: 0x06001818 RID: 6168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006A5")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x6001818")]
			[Address(RVA = "0x5082D0", Offset = "0x5068D0", VA = "0x1805082D0")]
			set
			{
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006A6")]
		public UserControllerType ControllerType
		{
			[Token(Token = "0x6001819")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (set) Token: 0x0600181A RID: 6170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006A7")]
		public Utf8String ServerIp
		{
			[Token(Token = "0x600181A")]
			[Address(RVA = "0x508390", Offset = "0x506990", VA = "0x180508390")]
			set
			{
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006A8")]
		public Utf8String GameSessionId
		{
			[Token(Token = "0x600181B")]
			[Address(RVA = "0x508330", Offset = "0x506930", VA = "0x180508330")]
			set
			{
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600181C")]
		[Address(RVA = "0x5080F0", Offset = "0x5066F0", VA = "0x1805080F0", Slot = "4")]
		public void Set(ref BeginPlayerSessionOptions other)
		{
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600181D")]
		[Address(RVA = "0x507EE0", Offset = "0x5064E0", VA = "0x180507EE0", Slot = "5")]
		public void Set(ref BeginPlayerSessionOptions? other)
		{
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600181E")]
		[Address(RVA = "0x507E50", Offset = "0x506450", VA = "0x180507E50", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4000AB0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		[FieldOffset(Offset = "0x4")]
		private BeginPlayerSessionOptionsAccountIdInternal m_AccountId;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_DisplayName;

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x18")]
		private UserControllerType m_ControllerType;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ServerIp;

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_GameSessionId;
	}
}
