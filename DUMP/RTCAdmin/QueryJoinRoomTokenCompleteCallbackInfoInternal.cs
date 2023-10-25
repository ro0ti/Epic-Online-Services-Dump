using System;


namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x0200024D RID: 589
	[Token(Token = "0x200024D")]
	internal struct QueryJoinRoomTokenCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryJoinRoomTokenCompleteCallbackInfo>, ISettable<QueryJoinRoomTokenCompleteCallbackInfo>, IDisposable
	{
		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00005234 File Offset: 0x00003434
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700040E")]
		public Result ResultCode
		{
			[Token(Token = "0x6001038")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001039")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700040F")]
		public object ClientData
		{
			[Token(Token = "0x600103A")]
			[Address(RVA = "0x4DFB10", Offset = "0x4DE110", VA = "0x1804DFB10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600103B")]
			[Address(RVA = "0x4DFC50", Offset = "0x4DE250", VA = "0x1804DFC50")]
			set
			{
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0000524C File Offset: 0x0000344C
		[Token(Token = "0x17000410")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600103C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000411")]
		public Utf8String RoomName
		{
			[Token(Token = "0x600103D")]
			[Address(RVA = "0x4DFB80", Offset = "0x4DE180", VA = "0x1804DFB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600103E")]
			[Address(RVA = "0x4DFCB0", Offset = "0x4DE2B0", VA = "0x1804DFCB0")]
			set
			{
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000412")]
		public Utf8String ClientBaseUrl
		{
			[Token(Token = "0x600103F")]
			[Address(RVA = "0x4DFAA0", Offset = "0x4DE0A0", VA = "0x1804DFAA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001040")]
			[Address(RVA = "0x4DFBF0", Offset = "0x4DE1F0", VA = "0x1804DFBF0")]
			set
			{
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00005264 File Offset: 0x00003464
		// (set) Token: 0x06001042 RID: 4162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000413")]
		public uint QueryId
		{
			[Token(Token = "0x6001041")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001042")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x0000527C File Offset: 0x0000347C
		// (set) Token: 0x06001044 RID: 4164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000414")]
		public uint TokenCount
		{
			[Token(Token = "0x6001043")]
			[Address(RVA = "0x3D6660", Offset = "0x3D4C60", VA = "0x1803D6660")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001044")]
			[Address(RVA = "0x4DE4A0", Offset = "0x4DCAA0", VA = "0x1804DE4A0")]
			set
			{
			}
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001045")]
		[Address(RVA = "0x4DF990", Offset = "0x4DDF90", VA = "0x1804DF990", Slot = "6")]
		public void Set(ref QueryJoinRoomTokenCompleteCallbackInfo other)
		{
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001046")]
		[Address(RVA = "0x4DF7E0", Offset = "0x4DDDE0", VA = "0x1804DF7E0", Slot = "7")]
		public void Set(ref QueryJoinRoomTokenCompleteCallbackInfo? other)
		{
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001047")]
		[Address(RVA = "0x4DF740", Offset = "0x4DDD40", VA = "0x1804DF740", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001048")]
		[Address(RVA = "0x4DF7B0", Offset = "0x4DDDB0", VA = "0x1804DF7B0", Slot = "5")]
		public void Get(out QueryJoinRoomTokenCompleteCallbackInfo output)
		{
		}

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ClientBaseUrl;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x20")]
		private uint m_QueryId;

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[FieldOffset(Offset = "0x24")]
		private uint m_TokenCount;
	}
}
