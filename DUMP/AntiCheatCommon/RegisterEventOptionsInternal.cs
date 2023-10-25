using System;


namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006E3 RID: 1763
	[Token(Token = "0x20006E3")]
	internal struct RegisterEventOptionsInternal : ISettable<RegisterEventOptions>, IDisposable
	{
		// Token: 0x17000D7C RID: 3452
		// (set) Token: 0x06002D4F RID: 11599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D7C")]
		public uint EventId
		{
			[Token(Token = "0x6002D4F")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (set) Token: 0x06002D50 RID: 11600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D7D")]
		public Utf8String EventName
		{
			[Token(Token = "0x6002D50")]
			[Address(RVA = "0x57E380", Offset = "0x57C980", VA = "0x18057E380")]
			set
			{
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (set) Token: 0x06002D51 RID: 11601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D7E")]
		public AntiCheatCommonEventType EventType
		{
			[Token(Token = "0x6002D51")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (set) Token: 0x06002D52 RID: 11602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D7F")]
		public RegisterEventParamDef[] ParamDefs
		{
			[Token(Token = "0x6002D52")]
			[Address(RVA = "0x57E3E0", Offset = "0x57C9E0", VA = "0x18057E3E0")]
			set
			{
			}
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D53")]
		[Address(RVA = "0x57E2E0", Offset = "0x57C8E0", VA = "0x18057E2E0", Slot = "4")]
		public void Set(ref RegisterEventOptions other)
		{
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D54")]
		[Address(RVA = "0x57E1D0", Offset = "0x57C7D0", VA = "0x18057E1D0", Slot = "5")]
		public void Set(ref RegisterEventOptions? other)
		{
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D55")]
		[Address(RVA = "0x57E170", Offset = "0x57C770", VA = "0x18057E170", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400141C RID: 5148
		[Token(Token = "0x400141C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400141D RID: 5149
		[Token(Token = "0x400141D")]
		[FieldOffset(Offset = "0x4")]
		private uint m_EventId;

		// Token: 0x0400141E RID: 5150
		[Token(Token = "0x400141E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_EventName;

		// Token: 0x0400141F RID: 5151
		[Token(Token = "0x400141F")]
		[FieldOffset(Offset = "0x10")]
		private AntiCheatCommonEventType m_EventType;

		// Token: 0x04001420 RID: 5152
		[Token(Token = "0x4001420")]
		[FieldOffset(Offset = "0x14")]
		private uint m_ParamDefsCount;

		// Token: 0x04001421 RID: 5153
		[Token(Token = "0x4001421")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ParamDefs;
	}
}
