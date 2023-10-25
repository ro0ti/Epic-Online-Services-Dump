using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006DB RID: 1755
	[Token(Token = "0x20006DB")]
	internal struct OnClientActionRequiredCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnClientActionRequiredCallbackInfo>, ISettable<OnClientActionRequiredCallbackInfo>, IDisposable
	{
		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D5C")]
		public object ClientData
		{
			[Token(Token = "0x6002CFD")]
			[Address(RVA = "0x577670", Offset = "0x575C70", VA = "0x180577670")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CFE")]
			[Address(RVA = "0x577740", Offset = "0x575D40", VA = "0x180577740")]
			set
			{
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x0000B8AC File Offset: 0x00009AAC
		[Token(Token = "0x17000D5D")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002CFF")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x0000B8C4 File Offset: 0x00009AC4
		// (set) Token: 0x06002D01 RID: 11521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D5E")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002D00")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002D01")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x0000B8DC File Offset: 0x00009ADC
		// (set) Token: 0x06002D03 RID: 11523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D5F")]
		public AntiCheatCommonClientAction ClientAction
		{
			[Token(Token = "0x6002D02")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return AntiCheatCommonClientAction.Invalid;
			}
			[Token(Token = "0x6002D03")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x0000B8F4 File Offset: 0x00009AF4
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D60")]
		public AntiCheatCommonClientActionReason ActionReasonCode
		{
			[Token(Token = "0x6002D04")]
			[Address(RVA = "0x3D5CE0", Offset = "0x3D42E0", VA = "0x1803D5CE0")]
			get
			{
				return AntiCheatCommonClientActionReason.Invalid;
			}
			[Token(Token = "0x6002D05")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D61")]
		public Utf8String ActionReasonDetailsString
		{
			[Token(Token = "0x6002D06")]
			[Address(RVA = "0x577600", Offset = "0x575C00", VA = "0x180577600")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D07")]
			[Address(RVA = "0x5776E0", Offset = "0x575CE0", VA = "0x1805776E0")]
			set
			{
			}
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D08")]
		[Address(RVA = "0x5773F0", Offset = "0x5759F0", VA = "0x1805773F0", Slot = "6")]
		public void Set(ref OnClientActionRequiredCallbackInfo other)
		{
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D09")]
		[Address(RVA = "0x5774B0", Offset = "0x575AB0", VA = "0x1805774B0", Slot = "7")]
		public void Set(ref OnClientActionRequiredCallbackInfo? other)
		{
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D0A")]
		[Address(RVA = "0x577370", Offset = "0x575970", VA = "0x180577370", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D0B")]
		[Address(RVA = "0x5773D0", Offset = "0x5759D0", VA = "0x1805773D0", Slot = "5")]
		public void Get(out OnClientActionRequiredCallbackInfo output)
		{
		}

		// Token: 0x040013FE RID: 5118
		[Token(Token = "0x40013FE")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040013FF RID: 5119
		[Token(Token = "0x40013FF")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientHandle;

		// Token: 0x04001400 RID: 5120
		[Token(Token = "0x4001400")]
		[FieldOffset(Offset = "0x10")]
		private AntiCheatCommonClientAction m_ClientAction;

		// Token: 0x04001401 RID: 5121
		[Token(Token = "0x4001401")]
		[FieldOffset(Offset = "0x14")]
		private AntiCheatCommonClientActionReason m_ActionReasonCode;

		// Token: 0x04001402 RID: 5122
		[Token(Token = "0x4001402")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ActionReasonDetailsString;
	}
}
