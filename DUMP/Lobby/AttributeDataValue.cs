using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003AB RID: 939
	[Token(Token = "0x20003AB")]
	public struct AttributeDataValue
	{
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x00006F14 File Offset: 0x00005114
		// (set) Token: 0x060018A9 RID: 6313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006C7")]
		public long? AsInt64
		{
			[Token(Token = "0x60018A8")]
			[Address(RVA = "0x506A00", Offset = "0x505000", VA = "0x180506A00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018A9")]
			[Address(RVA = "0x506F40", Offset = "0x505540", VA = "0x180506F40")]
			set
			{
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x00006F2C File Offset: 0x0000512C
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006C8")]
		public double? AsDouble
		{
			[Token(Token = "0x60018AA")]
			[Address(RVA = "0x506960", Offset = "0x504F60", VA = "0x180506960")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018AB")]
			[Address(RVA = "0x506EA0", Offset = "0x5054A0", VA = "0x180506EA0")]
			set
			{
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x00006F44 File Offset: 0x00005144
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006C9")]
		public bool? AsBool
		{
			[Token(Token = "0x60018AC")]
			[Address(RVA = "0x5068D0", Offset = "0x504ED0", VA = "0x1805068D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018AD")]
			[Address(RVA = "0x506E10", Offset = "0x505410", VA = "0x180506E10")]
			set
			{
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006CA")]
		public Utf8String AsUtf8
		{
			[Token(Token = "0x60018AE")]
			[Address(RVA = "0x506AA0", Offset = "0x5050A0", VA = "0x180506AA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018AF")]
			[Address(RVA = "0x506FE0", Offset = "0x5055E0", VA = "0x180506FE0")]
			set
			{
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00006F5C File Offset: 0x0000515C
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006CB")]
		public AttributeType ValueType
		{
			[Token(Token = "0x60018B0")]
			[Address(RVA = "0x3D2E80", Offset = "0x3D1480", VA = "0x1803D2E80")]
			get
			{
				return AttributeType.Boolean;
			}
			[Token(Token = "0x60018B1")]
			[Address(RVA = "0x3D2EB0", Offset = "0x3D14B0", VA = "0x1803D2EB0")]
			private set
			{
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00006F74 File Offset: 0x00005174
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x506BB0", Offset = "0x5051B0", VA = "0x180506BB0")]
		public static implicit operator AttributeDataValue(long value)
		{
			return default(AttributeDataValue);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00006F8C File Offset: 0x0000518C
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x506CA0", Offset = "0x5052A0", VA = "0x180506CA0")]
		public static implicit operator AttributeDataValue(double value)
		{
			return default(AttributeDataValue);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00006FA4 File Offset: 0x000051A4
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x506D90", Offset = "0x505390", VA = "0x180506D90")]
		public static implicit operator AttributeDataValue(bool value)
		{
			return default(AttributeDataValue);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00006FBC File Offset: 0x000051BC
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x506B80", Offset = "0x505180", VA = "0x180506B80")]
		public static implicit operator AttributeDataValue(Utf8String value)
		{
			return default(AttributeDataValue);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00006FD4 File Offset: 0x000051D4
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x506B30", Offset = "0x505130", VA = "0x180506B30")]
		public static implicit operator AttributeDataValue(string value)
		{
			return default(AttributeDataValue);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x5066A0", Offset = "0x504CA0", VA = "0x1805066A0")]
		internal void Set(ref AttributeDataValueInternal other)
		{
		}

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4000B17")]
		[FieldOffset(Offset = "0x0")]
		private long? m_AsInt64;

		// Token: 0x04000B18 RID: 2840
		[Token(Token = "0x4000B18")]
		[FieldOffset(Offset = "0x10")]
		private double? m_AsDouble;

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4000B19")]
		[FieldOffset(Offset = "0x20")]
		private bool? m_AsBool;

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		[FieldOffset(Offset = "0x28")]
		private Utf8String m_AsUtf8;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		[FieldOffset(Offset = "0x30")]
		private AttributeType m_ValueType;
	}
}
