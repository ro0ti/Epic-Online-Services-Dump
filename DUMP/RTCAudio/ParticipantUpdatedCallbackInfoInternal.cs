using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200020F RID: 527
	[Token(Token = "0x200020F")]
	internal struct ParticipantUpdatedCallbackInfoInternal : ICallbackInfoInternal, IGettable<ParticipantUpdatedCallbackInfo>, ISettable<ParticipantUpdatedCallbackInfo>, IDisposable
	{
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700036D")]
		public object ClientData
		{
			[Token(Token = "0x6000E75")]
			[Address(RVA = "0x4DE260", Offset = "0x4DC860", VA = "0x1804DE260")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E76")]
			[Address(RVA = "0x4DE4B0", Offset = "0x4DCAB0", VA = "0x1804DE4B0")]
			set
			{
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00004B5C File Offset: 0x00002D5C
		[Token(Token = "0x1700036E")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000E77")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700036F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000E78")]
			[Address(RVA = "0x4DE2D0", Offset = "0x4DC8D0", VA = "0x1804DE2D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E79")]
			[Address(RVA = "0x4DE510", Offset = "0x4DCB10", VA = "0x1804DE510")]
			set
			{
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000370")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000E7A")]
			[Address(RVA = "0x4DE3D0", Offset = "0x4DC9D0", VA = "0x1804DE3D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E7B")]
			[Address(RVA = "0x4DE5D0", Offset = "0x4DCBD0", VA = "0x1804DE5D0")]
			set
			{
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000371")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6000E7C")]
			[Address(RVA = "0x4DE350", Offset = "0x4DC950", VA = "0x1804DE350")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E7D")]
			[Address(RVA = "0x4DE570", Offset = "0x4DCB70", VA = "0x1804DE570")]
			set
			{
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00004B74 File Offset: 0x00002D74
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000372")]
		public bool Speaking
		{
			[Token(Token = "0x6000E7E")]
			[Address(RVA = "0x4DE440", Offset = "0x4DCA40", VA = "0x1804DE440")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E7F")]
			[Address(RVA = "0x4DE630", Offset = "0x4DCC30", VA = "0x1804DE630")]
			set
			{
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00004B8C File Offset: 0x00002D8C
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000373")]
		public RTCAudioStatus AudioStatus
		{
			[Token(Token = "0x6000E80")]
			[Address(RVA = "0x3D6660", Offset = "0x3D4C60", VA = "0x1803D6660")]
			get
			{
				return RTCAudioStatus.Unsupported;
			}
			[Token(Token = "0x6000E81")]
			[Address(RVA = "0x4DE4A0", Offset = "0x4DCAA0", VA = "0x1804DE4A0")]
			set
			{
			}
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x4DE0D0", Offset = "0x4DC6D0", VA = "0x1804DE0D0", Slot = "6")]
		public void Set(ref ParticipantUpdatedCallbackInfo other)
		{
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x4DDEB0", Offset = "0x4DC4B0", VA = "0x1804DDEB0", Slot = "7")]
		public void Set(ref ParticipantUpdatedCallbackInfo? other)
		{
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x4DDE10", Offset = "0x4DC410", VA = "0x1804DDE10", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x4DDE80", Offset = "0x4DC480", VA = "0x1804DDE80", Slot = "5")]
		public void Get(out ParticipantUpdatedCallbackInfo output)
		{
		}

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ParticipantId;

		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0x20")]
		private int m_Speaking;

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0x24")]
		private RTCAudioStatus m_AudioStatus;
	}
}
