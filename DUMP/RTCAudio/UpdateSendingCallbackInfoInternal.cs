using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000237 RID: 567
	[Token(Token = "0x2000237")]
	internal struct UpdateSendingCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateSendingCallbackInfo>, ISettable<UpdateSendingCallbackInfo>, IDisposable
	{
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00005024 File Offset: 0x00003224
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003DA")]
		public Result ResultCode
		{
			[Token(Token = "0x6000FA6")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000FA7")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003DB")]
		public object ClientData
		{
			[Token(Token = "0x6000FA8")]
			[Address(RVA = "0x4E9ED0", Offset = "0x4E84D0", VA = "0x1804E9ED0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FA9")]
			[Address(RVA = "0x4EA030", Offset = "0x4E8630", VA = "0x1804EA030")]
			set
			{
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0000503C File Offset: 0x0000323C
		[Token(Token = "0x170003DC")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000FAA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003DD")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000FAB")]
			[Address(RVA = "0x4E9F40", Offset = "0x4E8540", VA = "0x1804E9F40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FAC")]
			[Address(RVA = "0x4EA090", Offset = "0x4E8690", VA = "0x1804EA090")]
			set
			{
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003DE")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000FAD")]
			[Address(RVA = "0x4E9FC0", Offset = "0x4E85C0", VA = "0x1804E9FC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FAE")]
			[Address(RVA = "0x4EA0F0", Offset = "0x4E86F0", VA = "0x1804EA0F0")]
			set
			{
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00005054 File Offset: 0x00003254
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003DF")]
		public RTCAudioStatus AudioStatus
		{
			[Token(Token = "0x6000FAF")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			get
			{
				return RTCAudioStatus.Unsupported;
			}
			[Token(Token = "0x6000FB0")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x4E9C30", Offset = "0x4E8230", VA = "0x1804E9C30", Slot = "6")]
		public void Set(ref UpdateSendingCallbackInfo other)
		{
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x4E9D40", Offset = "0x4E8340", VA = "0x1804E9D40", Slot = "7")]
		public void Set(ref UpdateSendingCallbackInfo? other)
		{
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0x4E9B90", Offset = "0x4E8190", VA = "0x1804E9B90", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FB4")]
		[Address(RVA = "0x4E9C00", Offset = "0x4E8200", VA = "0x1804E9C00", Slot = "5")]
		public void Get(out UpdateSendingCallbackInfo output)
		{
		}

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_RoomName;

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x20")]
		private RTCAudioStatus m_AudioStatus;
	}
}
