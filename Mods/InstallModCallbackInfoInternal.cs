using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000368 RID: 872
	[Token(Token = "0x2000368")]
	internal struct InstallModCallbackInfoInternal : ICallbackInfoInternal, IGettable<InstallModCallbackInfo>, ISettable<InstallModCallbackInfo>, IDisposable
	{
		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x00006ADC File Offset: 0x00004CDC
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700066C")]
		public Result ResultCode
		{
			[Token(Token = "0x6001763")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001764")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700066D")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001765")]
			[Address(RVA = "0x50D270", Offset = "0x50B870", VA = "0x18050D270")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001766")]
			[Address(RVA = "0x50D3D0", Offset = "0x50B9D0", VA = "0x18050D3D0")]
			set
			{
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700066E")]
		public object ClientData
		{
			[Token(Token = "0x6001767")]
			[Address(RVA = "0x50D200", Offset = "0x50B800", VA = "0x18050D200")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001768")]
			[Address(RVA = "0x50D370", Offset = "0x50B970", VA = "0x18050D370")]
			set
			{
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00006AF4 File Offset: 0x00004CF4
		[Token(Token = "0x1700066F")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001769")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x00006B0C File Offset: 0x00004D0C
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000670")]
		public ModIdentifier? Mod
		{
			[Token(Token = "0x600176A")]
			[Address(RVA = "0x50D2F0", Offset = "0x50B8F0", VA = "0x18050D2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600176B")]
			[Address(RVA = "0x50D430", Offset = "0x50BA30", VA = "0x18050D430")]
			set
			{
			}
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600176C")]
		[Address(RVA = "0x50CF10", Offset = "0x50B510", VA = "0x18050CF10", Slot = "6")]
		public void Set(ref InstallModCallbackInfo other)
		{
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600176D")]
		[Address(RVA = "0x50D040", Offset = "0x50B640", VA = "0x18050D040", Slot = "7")]
		public void Set(ref InstallModCallbackInfo? other)
		{
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600176E")]
		[Address(RVA = "0x50CE70", Offset = "0x50B470", VA = "0x18050CE70", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600176F")]
		[Address(RVA = "0x50CEE0", Offset = "0x50B4E0", VA = "0x18050CEE0", Slot = "5")]
		public void Get(out InstallModCallbackInfo output)
		{
		}

		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ClientData;

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Mod;
	}
}
