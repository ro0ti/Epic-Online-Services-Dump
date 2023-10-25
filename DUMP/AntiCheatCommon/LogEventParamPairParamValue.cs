using System;


namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006C4 RID: 1732
	[Token(Token = "0x20006C4")]
	public struct LogEventParamPairParamValue
	{
		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x0000B1A4 File Offset: 0x000093A4
		// (set) Token: 0x06002C12 RID: 11282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CEA")]
		public AntiCheatCommonEventParamType ParamValueType
		{
			[Token(Token = "0x6002C11")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return AntiCheatCommonEventParamType.Invalid;
			}
			[Token(Token = "0x6002C12")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			private set
			{
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002C13 RID: 11283 RVA: 0x0000B1BC File Offset: 0x000093BC
		// (set) Token: 0x06002C14 RID: 11284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CEB")]
		public IntPtr? ClientHandle
		{
			[Token(Token = "0x6002C13")]
			[Address(RVA = "0x573720", Offset = "0x571D20", VA = "0x180573720")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C14")]
			[Address(RVA = "0x574200", Offset = "0x572800", VA = "0x180574200")]
			set
			{
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002C16 RID: 11286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CEC")]
		public Utf8String String
		{
			[Token(Token = "0x6002C15")]
			[Address(RVA = "0x573990", Offset = "0x571F90", VA = "0x180573990")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C16")]
			[Address(RVA = "0x574470", Offset = "0x572A70", VA = "0x180574470")]
			set
			{
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x0000B1D4 File Offset: 0x000093D4
		// (set) Token: 0x06002C18 RID: 11288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CED")]
		public uint? UInt32
		{
			[Token(Token = "0x6002C17")]
			[Address(RVA = "0x573A20", Offset = "0x572020", VA = "0x180573A20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C18")]
			[Address(RVA = "0x574500", Offset = "0x572B00", VA = "0x180574500")]
			set
			{
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x0000B1EC File Offset: 0x000093EC
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CEE")]
		public int? Int32
		{
			[Token(Token = "0x6002C19")]
			[Address(RVA = "0x5737C0", Offset = "0x571DC0", VA = "0x1805737C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C1A")]
			[Address(RVA = "0x5742A0", Offset = "0x5728A0", VA = "0x1805742A0")]
			set
			{
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x0000B204 File Offset: 0x00009404
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CEF")]
		public ulong? UInt64
		{
			[Token(Token = "0x6002C1B")]
			[Address(RVA = "0x573AB0", Offset = "0x5720B0", VA = "0x180573AB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C1C")]
			[Address(RVA = "0x574590", Offset = "0x572B90", VA = "0x180574590")]
			set
			{
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x0000B21C File Offset: 0x0000941C
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CF0")]
		public long? Int64
		{
			[Token(Token = "0x6002C1D")]
			[Address(RVA = "0x573850", Offset = "0x571E50", VA = "0x180573850")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C1E")]
			[Address(RVA = "0x574330", Offset = "0x572930", VA = "0x180574330")]
			set
			{
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x0000B234 File Offset: 0x00009434
		// (set) Token: 0x06002C20 RID: 11296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CF1")]
		public Vec3f Vec3f
		{
			[Token(Token = "0x6002C1F")]
			[Address(RVA = "0x573B50", Offset = "0x572150", VA = "0x180573B50")]
			get
			{
				return default(Vec3f);
			}
			[Token(Token = "0x6002C20")]
			[Address(RVA = "0x574630", Offset = "0x572C30", VA = "0x180574630")]
			set
			{
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x0000B24C File Offset: 0x0000944C
		// (set) Token: 0x06002C22 RID: 11298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CF2")]
		public Quat Quat
		{
			[Token(Token = "0x6002C21")]
			[Address(RVA = "0x5738F0", Offset = "0x571EF0", VA = "0x1805738F0")]
			get
			{
				return default(Quat);
			}
			[Token(Token = "0x6002C22")]
			[Address(RVA = "0x5743D0", Offset = "0x5729D0", VA = "0x1805743D0")]
			set
			{
			}
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x0000B264 File Offset: 0x00009464
		[Token(Token = "0x6002C23")]
		[Address(RVA = "0x573D00", Offset = "0x572300", VA = "0x180573D00")]
		public static implicit operator LogEventParamPairParamValue(IntPtr value)
		{
			return default(LogEventParamPairParamValue);
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x0000B27C File Offset: 0x0000947C
		[Token(Token = "0x6002C24")]
		[Address(RVA = "0x573C00", Offset = "0x572200", VA = "0x180573C00")]
		public static implicit operator LogEventParamPairParamValue(Utf8String value)
		{
			return default(LogEventParamPairParamValue);
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x0000B294 File Offset: 0x00009494
		[Token(Token = "0x6002C25")]
		[Address(RVA = "0x573FD0", Offset = "0x5725D0", VA = "0x180573FD0")]
		public static implicit operator LogEventParamPairParamValue(string value)
		{
			return default(LogEventParamPairParamValue);
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x0000B2AC File Offset: 0x000094AC
		[Token(Token = "0x6002C26")]
		[Address(RVA = "0x574170", Offset = "0x572770", VA = "0x180574170")]
		public static implicit operator LogEventParamPairParamValue(uint value)
		{
			return default(LogEventParamPairParamValue);
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x0000B2C4 File Offset: 0x000094C4
		[Token(Token = "0x6002C27")]
		[Address(RVA = "0x5740E0", Offset = "0x5726E0", VA = "0x1805740E0")]
		public static implicit operator LogEventParamPairParamValue(int value)
		{
			return default(LogEventParamPairParamValue);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x0000B2DC File Offset: 0x000094DC
		[Token(Token = "0x6002C28")]
		[Address(RVA = "0x573DF0", Offset = "0x5723F0", VA = "0x180573DF0")]
		public static implicit operator LogEventParamPairParamValue(ulong value)
		{
			return default(LogEventParamPairParamValue);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x0000B2F4 File Offset: 0x000094F4
		[Token(Token = "0x6002C29")]
		[Address(RVA = "0x573EE0", Offset = "0x5724E0", VA = "0x180573EE0")]
		public static implicit operator LogEventParamPairParamValue(long value)
		{
			return default(LogEventParamPairParamValue);
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x0000B30C File Offset: 0x0000950C
		[Token(Token = "0x6002C2A")]
		[Address(RVA = "0x574020", Offset = "0x572620", VA = "0x180574020")]
		public static implicit operator LogEventParamPairParamValue(Vec3f value)
		{
			return default(LogEventParamPairParamValue);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x0000B324 File Offset: 0x00009524
		[Token(Token = "0x6002C2B")]
		[Address(RVA = "0x573C40", Offset = "0x572240", VA = "0x180573C40")]
		public static implicit operator LogEventParamPairParamValue(Quat value)
		{
			return default(LogEventParamPairParamValue);
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C2C")]
		[Address(RVA = "0x573250", Offset = "0x571850", VA = "0x180573250")]
		internal void Set(ref LogEventParamPairParamValueInternal other)
		{
		}

		// Token: 0x04001382 RID: 4994
		[Token(Token = "0x4001382")]
		[FieldOffset(Offset = "0x0")]
		private AntiCheatCommonEventParamType m_ParamValueType;

		// Token: 0x04001383 RID: 4995
		[Token(Token = "0x4001383")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr? m_ClientHandle;

		// Token: 0x04001384 RID: 4996
		[Token(Token = "0x4001384")]
		[FieldOffset(Offset = "0x18")]
		private Utf8String m_String;

		// Token: 0x04001385 RID: 4997
		[Token(Token = "0x4001385")]
		[FieldOffset(Offset = "0x20")]
		private uint? m_UInt32;

		// Token: 0x04001386 RID: 4998
		[Token(Token = "0x4001386")]
		[FieldOffset(Offset = "0x28")]
		private int? m_Int32;

		// Token: 0x04001387 RID: 4999
		[Token(Token = "0x4001387")]
		[FieldOffset(Offset = "0x30")]
		private ulong? m_UInt64;

		// Token: 0x04001388 RID: 5000
		[Token(Token = "0x4001388")]
		[FieldOffset(Offset = "0x40")]
		private long? m_Int64;

		// Token: 0x04001389 RID: 5001
		[Token(Token = "0x4001389")]
		[FieldOffset(Offset = "0x50")]
		private Vec3f m_Vec3f;

		// Token: 0x0400138A RID: 5002
		[Token(Token = "0x400138A")]
		[FieldOffset(Offset = "0x5C")]
		private Quat m_Quat;
	}
}
