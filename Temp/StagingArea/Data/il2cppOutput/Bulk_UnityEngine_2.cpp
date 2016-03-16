#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>

struct t1072804841;
struct t284553113;
struct Il2CppObject;
struct t3148635335;
struct String_t;
struct t1967233988;
struct t11523773;
struct t1917318876;
struct t896427542;
struct t1291133240;
struct t1291133240_marshaled;
struct t4003675496;
struct t1716006665;
struct t3557331758;
struct t3557331758_marshaled;
struct t2344941421;
struct t3660574010;
struct MethodInfo_t;
struct Type_t;
struct t471424957;

#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "Il2CppArray.h"
#include "t1072804841.h"
#include "t1072804841MD.h"
#include "t284553113.h"
#include "t2779279689.h"
#include "Il2CppObjectMD.h"
#include "t2847414787.h"
#include "Il2CppObject.h"
#include "t284553113MD.h"
#include "t211005341.h"
#include "t403820581.h"
#include "t403820581MD.h"
#include "t3525329788.h"
#include "t3525329788MD.h"
#include "t156921283.h"
#include "t156921283MD.h"
#include "t2260061605.h"
#include "t2260061605MD.h"
#include "t4137084207MD.h"
#include "t3525329790MD.h"
#include "t3525329789MD.h"
#include "t4137084207.h"
#include "t2778693821.h"
#include "t3525329790.h"
#include "t958209021.h"
#include "t3525329789.h"
#include "t3148635335.h"
#include "t3148635335MD.h"
#include "t1967233988MD.h"
#include "String_t.h"
#include "t1967233988.h"
#include "t963216403.h"
#include "t963216403MD.h"
#include "mscorlib_ArrayTypes.h"
#include "String_tMD.h"
#include "t3760259642MD.h"
#include "t3760259642.h"
#include "t958209021MD.h"
#include "t1597001355MD.h"
#include "t2656823056.h"
#include "t2656823056MD.h"
#include "t1917318876.h"
#include "t1917318876MD.h"
#include "t3557331758MD.h"
#include "t896427542.h"
#include "t896427542MD.h"
#include "t1291133240.h"
#include "t1291133240MD.h"
#include "t4003675496.h"
#include "t4003675496MD.h"
#include "t498693649MD.h"
#include "t1716006665.h"
#include "t1716006665MD.h"
#include "t3557331758.h"
#include "t2344941421.h"
#include "t2344941421MD.h"
#include "t1623036922MD.h"
#include "t681132919.h"
#include "t681132919MD.h"
#include "t3007803305MD.h"
#include "t3785516670.h"
#include "t3785516670MD.h"
#include "MethodInfo_t.h"
#include "Type_t.h"
#include "t3660574010.h"
#include "t3660574010MD.h"
#include "t471424957.h"
#include "t471424957MD.h"
#include "t435505844.h"
#include "t2778772662MD.h"
#include "t2778772662.h"
#include "t435505844MD.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
extern "C"  void m856668951 (t1072804841 * __this, t284553113 * p0, const MethodInfo* method)
{
	{
		__this->fs1((-1));
		m1772956182(__this, NULL);
		t284553113 * L_0 = p0;
		__this->fs0(L_0);
		return;
	}
}
extern "C"  Il2CppObject * m1838268607 (t1072804841 * __this, const MethodInfo* method)
{
	{
		t284553113 * L_0 = __this->fg0();
		int32_t L_1 = __this->fg1();
		t284553113 * L_2 = m4040462992(L_0, L_1, NULL);
		return L_2;
	}
}
extern "C"  bool m1095530856 (t1072804841 * __this, const MethodInfo* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		t284553113 * L_0 = __this->fg0();
		int32_t L_1 = m2107810675(L_0, NULL);
		V_0 = L_1;
		int32_t L_2 = __this->fg1();
		int32_t L_3 = ((int32_t)((int32_t)L_2+(int32_t)1));
		V_1 = L_3;
		__this->fs1(L_3);
		int32_t L_4 = V_1;
		int32_t L_5 = V_0;
		return (bool)((((int32_t)L_4) < ((int32_t)L_5))? 1 : 0);
	}
}
extern "C"  void m258411155 (t1072804841 * __this, const MethodInfo* method)
{
	{
		__this->fs1((-1));
		return;
	}
}
// Conversion methods for marshalling of: UnityEngine.UICharInfo
extern "C" void t403820581_marshal(const t403820581& unmarshaled, t403820581_marshaled& marshaled)
{
	t3525329788_marshal(unmarshaled.fg0(), marshaled.f0);
	marshaled.f1 = unmarshaled.fg1();
}
extern "C" void t403820581_marshal_back(const t403820581_marshaled& marshaled, t403820581& unmarshaled)
{
	t3525329788  unmarshaled_cursorPos_temp;
	memset(&unmarshaled_cursorPos_temp, 0, sizeof(unmarshaled_cursorPos_temp));
	t3525329788_marshal_back(marshaled.f0, unmarshaled_cursorPos_temp);
	unmarshaled.fs0(unmarshaled_cursorPos_temp);
	float unmarshaled_charWidth_temp = 0.0f;
	unmarshaled_charWidth_temp = marshaled.f1;
	unmarshaled.fs1(unmarshaled_charWidth_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.UICharInfo
extern "C" void t403820581_marshal_cleanup(t403820581_marshaled& marshaled)
{
	t3525329788_marshal_cleanup(marshaled.f0);
}
// Conversion methods for marshalling of: UnityEngine.UILineInfo
extern "C" void t156921283_marshal(const t156921283& unmarshaled, t156921283_marshaled& marshaled)
{
	marshaled.f0 = unmarshaled.fg0();
	marshaled.f1 = unmarshaled.fg1();
	marshaled.f2 = unmarshaled.fg2();
}
extern "C" void t156921283_marshal_back(const t156921283_marshaled& marshaled, t156921283& unmarshaled)
{
	int32_t unmarshaled_startCharIdx_temp = 0;
	unmarshaled_startCharIdx_temp = marshaled.f0;
	unmarshaled.fs0(unmarshaled_startCharIdx_temp);
	int32_t unmarshaled_height_temp = 0;
	unmarshaled_height_temp = marshaled.f1;
	unmarshaled.fs1(unmarshaled_height_temp);
	float unmarshaled_topY_temp = 0.0f;
	unmarshaled_topY_temp = marshaled.f2;
	unmarshaled.fs2(unmarshaled_topY_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.UILineInfo
extern "C" void t156921283_marshal_cleanup(t156921283_marshaled& marshaled)
{
}
extern TypeInfo* t2260061605_TI_var;
extern const uint32_t m2134470424_MetadataUsageId;
extern "C"  void m2134470424 (Il2CppObject * __this , const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m2134470424_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	t2260061605  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		t4137084207  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m576906339(&L_0, ((int32_t)255), ((int32_t)255), ((int32_t)255), ((int32_t)255), NULL);
		((t2260061605_SFs*)t2260061605_TI_var->static_fields)->fs6(L_0);
		t3525329790  L_1;
		memset(&L_1, 0, sizeof(L_1));
		m2441427762(&L_1, (1.0f), (0.0f), (0.0f), (-1.0f), NULL);
		((t2260061605_SFs*)t2260061605_TI_var->static_fields)->fs7(L_1);
		Initobj (t2260061605_TI_var, (&V_0));
		t3525329789  L_2 = m2017759730(NULL, NULL);
		(&V_0)->fs0(L_2);
		t3525329789  L_3 = m1326515313(NULL, NULL);
		(&V_0)->fs1(L_3);
		t3525329790  L_4 = ((t2260061605_SFs*)t2260061605_TI_var->static_fields)->fg7();
		(&V_0)->fs5(L_4);
		t4137084207  L_5 = ((t2260061605_SFs*)t2260061605_TI_var->static_fields)->fg6();
		(&V_0)->fs2(L_5);
		t3525329788  L_6 = m199872368(NULL, NULL);
		(&V_0)->fs3(L_6);
		t3525329788  L_7 = m199872368(NULL, NULL);
		(&V_0)->fs4(L_7);
		t2260061605  L_8 = V_0;
		((t2260061605_SFs*)t2260061605_TI_var->static_fields)->fs8(L_8);
		return;
	}
}
// Conversion methods for marshalling of: UnityEngine.UIVertex
extern "C" void t2260061605_marshal(const t2260061605& unmarshaled, t2260061605_marshaled& marshaled)
{
	t3525329789_marshal(unmarshaled.fg0(), marshaled.f0);
	t3525329789_marshal(unmarshaled.fg1(), marshaled.f1);
	t4137084207_marshal(unmarshaled.fg2(), marshaled.f2);
	t3525329788_marshal(unmarshaled.fg3(), marshaled.f3);
	t3525329788_marshal(unmarshaled.fg4(), marshaled.f4);
	t3525329790_marshal(unmarshaled.fg5(), marshaled.f5);
}
extern "C" void t2260061605_marshal_back(const t2260061605_marshaled& marshaled, t2260061605& unmarshaled)
{
	t3525329789  unmarshaled_position_temp;
	memset(&unmarshaled_position_temp, 0, sizeof(unmarshaled_position_temp));
	t3525329789_marshal_back(marshaled.f0, unmarshaled_position_temp);
	unmarshaled.fs0(unmarshaled_position_temp);
	t3525329789  unmarshaled_normal_temp;
	memset(&unmarshaled_normal_temp, 0, sizeof(unmarshaled_normal_temp));
	t3525329789_marshal_back(marshaled.f1, unmarshaled_normal_temp);
	unmarshaled.fs1(unmarshaled_normal_temp);
	t4137084207  unmarshaled_color_temp;
	memset(&unmarshaled_color_temp, 0, sizeof(unmarshaled_color_temp));
	t4137084207_marshal_back(marshaled.f2, unmarshaled_color_temp);
	unmarshaled.fs2(unmarshaled_color_temp);
	t3525329788  unmarshaled_uv0_temp;
	memset(&unmarshaled_uv0_temp, 0, sizeof(unmarshaled_uv0_temp));
	t3525329788_marshal_back(marshaled.f3, unmarshaled_uv0_temp);
	unmarshaled.fs3(unmarshaled_uv0_temp);
	t3525329788  unmarshaled_uv1_temp;
	memset(&unmarshaled_uv1_temp, 0, sizeof(unmarshaled_uv1_temp));
	t3525329788_marshal_back(marshaled.f4, unmarshaled_uv1_temp);
	unmarshaled.fs4(unmarshaled_uv1_temp);
	t3525329790  unmarshaled_tangent_temp;
	memset(&unmarshaled_tangent_temp, 0, sizeof(unmarshaled_tangent_temp));
	t3525329790_marshal_back(marshaled.f5, unmarshaled_tangent_temp);
	unmarshaled.fs5(unmarshaled_tangent_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.UIVertex
extern "C" void t2260061605_marshal_cleanup(t2260061605_marshaled& marshaled)
{
	t3525329789_marshal_cleanup(marshaled.f0);
	t3525329789_marshal_cleanup(marshaled.f1);
	t4137084207_marshal_cleanup(marshaled.f2);
	t3525329788_marshal_cleanup(marshaled.f3);
	t3525329788_marshal_cleanup(marshaled.f4);
	t3525329790_marshal_cleanup(marshaled.f5);
}
extern Il2CppCodeGenString* _stringLiteral3200128946;
extern const uint32_t m1176480467_MetadataUsageId;
extern "C"  void m1176480467 (t3148635335 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m1176480467_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		m3870771296(__this, _stringLiteral3200128946, NULL);
		m3566571225(__this, ((int32_t)-2147467261), NULL);
		return;
	}
}
extern "C"  void m743662351 (t3148635335 * __this, String_t* p0, const MethodInfo* method)
{
	{
		String_t* L_0 = p0;
		m3870771296(__this, L_0, NULL);
		m3566571225(__this, ((int32_t)-2147467261), NULL);
		return;
	}
}
extern "C"  void m2780758535 (t3148635335 * __this, String_t* p0, t1967233988 * p1, const MethodInfo* method)
{
	{
		String_t* L_0 = p0;
		t1967233988 * L_1 = p1;
		m1328171222(__this, L_0, L_1, NULL);
		m3566571225(__this, ((int32_t)-2147467261), NULL);
		return;
	}
}
extern TypeInfo* String_t_TI_var;
extern const uint32_t m427603113_MetadataUsageId;
extern "C"  String_t* m427603113 (Il2CppObject * __this , String_t* p0, t11523773* p1, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m427603113_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		String_t* L_0 = p0;
		t11523773* L_1 = p1;
		IL2CPP_RUNTIME_CLASS_INIT(String_t_TI_var);
		String_t* L_2 = m4050103162(NULL, L_0, L_1, NULL);
		return L_2;
	}
}
extern "C"  void m1517109030 (t3525329788 * __this, float p0, float p1, const MethodInfo* method)
{
	{
		float L_0 = p0;
		__this->fs1(L_0);
		float L_1 = p1;
		__this->fs2(L_1);
		return;
	}
}
extern TypeInfo* t3760259642_TI_var;
extern Il2CppCodeGenString* _stringLiteral3517435145;
extern const uint32_t m2185542843_MetadataUsageId;
extern "C"  float m2185542843 (t3525329788 * __this, int32_t p0, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m2185542843_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	int32_t V_0 = 0;
	{
		int32_t L_0 = p0;
		V_0 = L_0;
		int32_t L_1 = V_0;
		if (!L_1)
		{
			goto IL_0014;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)1)))
		{
			goto IL_001b;
		}
	}
	{
		goto IL_0022;
	}

IL_0014:
	{
		float L_3 = __this->fg1();
		return L_3;
	}

IL_001b:
	{
		float L_4 = __this->fg2();
		return L_4;
	}

IL_0022:
	{
		t3760259642 * L_5 = (t3760259642 *)il2cpp_codegen_object_new(t3760259642_TI_var);
		m1621772274(L_5, _stringLiteral3517435145, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5);
	}
}
extern TypeInfo* t3760259642_TI_var;
extern Il2CppCodeGenString* _stringLiteral3517435145;
extern const uint32_t m2767519328_MetadataUsageId;
extern "C"  void m2767519328 (t3525329788 * __this, int32_t p0, float p1, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m2767519328_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	int32_t V_0 = 0;
	{
		int32_t L_0 = p0;
		V_0 = L_0;
		int32_t L_1 = V_0;
		if (!L_1)
		{
			goto IL_0014;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)1)))
		{
			goto IL_0020;
		}
	}
	{
		goto IL_002c;
	}

IL_0014:
	{
		float L_3 = p1;
		__this->fs1(L_3);
		goto IL_0037;
	}

IL_0020:
	{
		float L_4 = p1;
		__this->fs2(L_4);
		goto IL_0037;
	}

IL_002c:
	{
		t3760259642 * L_5 = (t3760259642 *)il2cpp_codegen_object_new(t3760259642_TI_var);
		m1621772274(L_5, _stringLiteral3517435145, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5);
	}

IL_0037:
	{
		return;
	}
}
extern "C"  t3525329788  m1743563745 (Il2CppObject * __this , t3525329788  p0, t3525329788  p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p1)->fg1();
		float L_2 = (&p0)->fg2();
		float L_3 = (&p1)->fg2();
		t3525329788  L_4;
		memset(&L_4, 0, sizeof(L_4));
		m1517109030(&L_4, ((float)((float)L_0*(float)L_1)), ((float)((float)L_2*(float)L_3)), NULL);
		return L_4;
	}
}
extern "C"  void m195575125 (t3525329788 * __this, const MethodInfo* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = m1987058139(__this, NULL);
		V_0 = L_0;
		float L_1 = V_0;
		if ((!(((float)L_1) > ((float)(1.0E-05f)))))
		{
			goto IL_0029;
		}
	}
	{
		float L_2 = V_0;
		t3525329788  L_3 = m747627697(NULL, (*(t3525329788 *)__this), L_2, NULL);
		(*(t3525329788 *)__this) = L_3;
		goto IL_0034;
	}

IL_0029:
	{
		t3525329788  L_4 = m199872368(NULL, NULL);
		(*(t3525329788 *)__this) = L_4;
	}

IL_0034:
	{
		return;
	}
}
extern "C"  t3525329788  m123128511 (t3525329788 * __this, const MethodInfo* method)
{
	t3525329788  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = __this->fg1();
		float L_1 = __this->fg2();
		m1517109030((&V_0), L_0, L_1, NULL);
		m195575125((&V_0), NULL);
		t3525329788  L_2 = V_0;
		return L_2;
	}
}
extern TypeInfo* t11523773_TI_var;
extern TypeInfo* t958209021_TI_var;
extern Il2CppCodeGenString* _stringLiteral3928503634;
extern const uint32_t m3859776067_MetadataUsageId;
extern "C"  String_t* m3859776067 (t3525329788 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m3859776067_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		t11523773* L_0 = ((t11523773*)SZArrayNew(t11523773_TI_var, (uint32_t)2));
		float L_1 = __this->fg1();
		float L_2 = L_1;
		Il2CppObject * L_3 = Box(t958209021_TI_var, &L_2);
		ArrayElementTypeCheck (L_0, L_3);
		(L_0)->SetAt(static_cast<il2cpp_array_size_t>(0), (Il2CppObject *)L_3);
		t11523773* L_4 = L_0;
		float L_5 = __this->fg2();
		float L_6 = L_5;
		Il2CppObject * L_7 = Box(t958209021_TI_var, &L_6);
		ArrayElementTypeCheck (L_4, L_7);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(1), (Il2CppObject *)L_7);
		String_t* L_8 = m427603113(NULL, _stringLiteral3928503634, L_4, NULL);
		return L_8;
	}
}
extern "C"  int32_t m128434585 (t3525329788 * __this, const MethodInfo* method)
{
	{
		float* L_0 = __this->fag1();
		int32_t L_1 = m65342520(L_0, NULL);
		float* L_2 = __this->fag2();
		int32_t L_3 = m65342520(L_2, NULL);
		return ((int32_t)((int32_t)L_1^(int32_t)((int32_t)((int32_t)L_3<<(int32_t)2))));
	}
}
extern TypeInfo* t3525329788_TI_var;
extern const uint32_t m3404198849_MetadataUsageId;
extern "C"  bool m3404198849 (t3525329788 * __this, Il2CppObject * p0, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m3404198849_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	t3525329788  V_0;
	memset(&V_0, 0, sizeof(V_0));
	int32_t G_B5_0 = 0;
	{
		Il2CppObject * L_0 = p0;
		if (((Il2CppObject *)IsInstSealed(L_0, t3525329788_TI_var)))
		{
			goto IL_000d;
		}
	}
	{
		return (bool)0;
	}

IL_000d:
	{
		Il2CppObject * L_1 = p0;
		V_0 = ((*(t3525329788 *)((t3525329788 *)UnBox (L_1, t3525329788_TI_var))));
		float* L_2 = __this->fag1();
		float L_3 = (&V_0)->fg1();
		bool L_4 = m2110115959(L_2, L_3, NULL);
		if (!L_4)
		{
			goto IL_003f;
		}
	}
	{
		float* L_5 = __this->fag2();
		float L_6 = (&V_0)->fg2();
		bool L_7 = m2110115959(L_5, L_6, NULL);
		G_B5_0 = ((int32_t)(L_7));
		goto IL_0040;
	}

IL_003f:
	{
		G_B5_0 = 0;
	}

IL_0040:
	{
		return (bool)G_B5_0;
	}
}
extern "C"  float m2437602225 (Il2CppObject * __this , t3525329788  p0, t3525329788  p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p1)->fg1();
		float L_2 = (&p0)->fg2();
		float L_3 = (&p1)->fg2();
		return ((float)((float)((float)((float)L_0*(float)L_1))+(float)((float)((float)L_2*(float)L_3))));
	}
}
extern TypeInfo* t1597001355_TI_var;
extern const uint32_t m1987058139_MetadataUsageId;
extern "C"  float m1987058139 (t3525329788 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m1987058139_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		float L_0 = __this->fg1();
		float L_1 = __this->fg1();
		float L_2 = __this->fg2();
		float L_3 = __this->fg2();
		IL2CPP_RUNTIME_CLASS_INIT(t1597001355_TI_var);
		float L_4 = sqrtf(((float)((float)((float)((float)L_0*(float)L_1))+(float)((float)((float)L_2*(float)L_3)))));
		return L_4;
	}
}
extern "C"  float m996072851 (t3525329788 * __this, const MethodInfo* method)
{
	{
		float L_0 = __this->fg1();
		float L_1 = __this->fg1();
		float L_2 = __this->fg2();
		float L_3 = __this->fg2();
		return ((float)((float)((float)((float)L_0*(float)L_1))+(float)((float)((float)L_2*(float)L_3))));
	}
}
extern TypeInfo* t1597001355_TI_var;
extern const uint32_t m3950144551_MetadataUsageId;
extern "C"  float m3950144551 (Il2CppObject * __this , t3525329788  p0, t3525329788  p1, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m3950144551_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		t3525329788  L_0 = m123128511((&p0), NULL);
		t3525329788  L_1 = m123128511((&p1), NULL);
		float L_2 = m2437602225(NULL, L_0, L_1, NULL);
		IL2CPP_RUNTIME_CLASS_INIT(t1597001355_TI_var);
		float L_3 = m3872743893(NULL, L_2, (-1.0f), (1.0f), NULL);
		float L_4 = acosf(L_3);
		return ((float)((float)L_4*(float)(57.29578f)));
	}
}
extern "C"  float m340609291 (Il2CppObject * __this , t3525329788  p0, t3525329788  p1, const MethodInfo* method)
{
	t3525329788  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		t3525329788  L_0 = p0;
		t3525329788  L_1 = p1;
		t3525329788  L_2 = m2097149401(NULL, L_0, L_1, NULL);
		V_0 = L_2;
		float L_3 = m1987058139((&V_0), NULL);
		return L_3;
	}
}
extern "C"  float m4007443280 (Il2CppObject * __this , t3525329788  p0, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p0)->fg1();
		float L_2 = (&p0)->fg2();
		float L_3 = (&p0)->fg2();
		return ((float)((float)((float)((float)L_0*(float)L_1))+(float)((float)((float)L_2*(float)L_3))));
	}
}
extern "C"  t3525329788  m199872368 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329788  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m1517109030(&L_0, (0.0f), (0.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329788  m2767488832 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329788  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m1517109030(&L_0, (1.0f), (1.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329788  m1197831267 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329788  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m1517109030(&L_0, (0.0f), (1.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329788  m3495203638 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329788  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m1517109030(&L_0, (1.0f), (0.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329788  m1173049553 (Il2CppObject * __this , t3525329788  p0, t3525329788  p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p1)->fg1();
		float L_2 = (&p0)->fg2();
		float L_3 = (&p1)->fg2();
		t3525329788  L_4;
		memset(&L_4, 0, sizeof(L_4));
		m1517109030(&L_4, ((float)((float)L_0+(float)L_1)), ((float)((float)L_2+(float)L_3)), NULL);
		return L_4;
	}
}
extern "C"  t3525329788  m2097149401 (Il2CppObject * __this , t3525329788  p0, t3525329788  p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p1)->fg1();
		float L_2 = (&p0)->fg2();
		float L_3 = (&p1)->fg2();
		t3525329788  L_4;
		memset(&L_4, 0, sizeof(L_4));
		m1517109030(&L_4, ((float)((float)L_0-(float)L_1)), ((float)((float)L_2-(float)L_3)), NULL);
		return L_4;
	}
}
extern "C"  t3525329788  m1738245082 (Il2CppObject * __this , t3525329788  p0, float p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = p1;
		float L_2 = (&p0)->fg2();
		float L_3 = p1;
		t3525329788  L_4;
		memset(&L_4, 0, sizeof(L_4));
		m1517109030(&L_4, ((float)((float)L_0*(float)L_1)), ((float)((float)L_2*(float)L_3)), NULL);
		return L_4;
	}
}
extern "C"  t3525329788  m747627697 (Il2CppObject * __this , t3525329788  p0, float p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = p1;
		float L_2 = (&p0)->fg2();
		float L_3 = p1;
		t3525329788  L_4;
		memset(&L_4, 0, sizeof(L_4));
		m1517109030(&L_4, ((float)((float)L_0/(float)L_1)), ((float)((float)L_2/(float)L_3)), NULL);
		return L_4;
	}
}
extern "C"  bool m1927481448 (Il2CppObject * __this , t3525329788  p0, t3525329788  p1, const MethodInfo* method)
{
	{
		t3525329788  L_0 = p0;
		t3525329788  L_1 = p1;
		t3525329788  L_2 = m2097149401(NULL, L_0, L_1, NULL);
		float L_3 = m4007443280(NULL, L_2, NULL);
		return (bool)((((float)L_3) < ((float)(9.99999944E-11f)))? 1 : 0);
	}
}
extern "C"  bool m1638984867 (Il2CppObject * __this , t3525329788  p0, t3525329788  p1, const MethodInfo* method)
{
	{
		t3525329788  L_0 = p0;
		t3525329788  L_1 = p1;
		t3525329788  L_2 = m2097149401(NULL, L_0, L_1, NULL);
		float L_3 = m4007443280(NULL, L_2, NULL);
		return (bool)((((int32_t)((!(((float)L_3) >= ((float)(9.99999944E-11f))))? 1 : 0)) == ((int32_t)0))? 1 : 0);
	}
}
extern "C"  t3525329788  m4083860659 (Il2CppObject * __this , t3525329789  p0, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p0)->fg2();
		t3525329788  L_2;
		memset(&L_2, 0, sizeof(L_2));
		m1517109030(&L_2, L_0, L_1, NULL);
		return L_2;
	}
}
extern "C"  t3525329789  m482286037 (Il2CppObject * __this , t3525329788  p0, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p0)->fg2();
		t3525329789  L_2;
		memset(&L_2, 0, sizeof(L_2));
		m2926210380(&L_2, L_0, L_1, (0.0f), NULL);
		return L_2;
	}
}
// Conversion methods for marshalling of: UnityEngine.Vector2
extern "C" void t3525329788_marshal(const t3525329788& unmarshaled, t3525329788_marshaled& marshaled)
{
	marshaled.f1 = unmarshaled.fg1();
	marshaled.f2 = unmarshaled.fg2();
}
extern "C" void t3525329788_marshal_back(const t3525329788_marshaled& marshaled, t3525329788& unmarshaled)
{
	float unmarshaled_x_temp = 0.0f;
	unmarshaled_x_temp = marshaled.f1;
	unmarshaled.fs1(unmarshaled_x_temp);
	float unmarshaled_y_temp = 0.0f;
	unmarshaled_y_temp = marshaled.f2;
	unmarshaled.fs2(unmarshaled_y_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.Vector2
extern "C" void t3525329788_marshal_cleanup(t3525329788_marshaled& marshaled)
{
}
extern "C"  void m2926210380 (t3525329789 * __this, float p0, float p1, float p2, const MethodInfo* method)
{
	{
		float L_0 = p0;
		__this->fs1(L_0);
		float L_1 = p1;
		__this->fs2(L_1);
		float L_2 = p2;
		__this->fs3(L_2);
		return;
	}
}
extern "C"  void m1846874791 (t3525329789 * __this, float p0, float p1, const MethodInfo* method)
{
	{
		float L_0 = p0;
		__this->fs1(L_0);
		float L_1 = p1;
		__this->fs2(L_1);
		__this->fs3((0.0f));
		return;
	}
}
extern TypeInfo* t1597001355_TI_var;
extern const uint32_t m650470329_MetadataUsageId;
extern "C"  t3525329789  m650470329 (Il2CppObject * __this , t3525329789  p0, t3525329789  p1, float p2, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m650470329_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		float L_0 = p2;
		IL2CPP_RUNTIME_CLASS_INIT(t1597001355_TI_var);
		float L_1 = m2272733930(NULL, L_0, NULL);
		p2 = L_1;
		float L_2 = (&p0)->fg1();
		float L_3 = (&p1)->fg1();
		float L_4 = (&p0)->fg1();
		float L_5 = p2;
		float L_6 = (&p0)->fg2();
		float L_7 = (&p1)->fg2();
		float L_8 = (&p0)->fg2();
		float L_9 = p2;
		float L_10 = (&p0)->fg3();
		float L_11 = (&p1)->fg3();
		float L_12 = (&p0)->fg3();
		float L_13 = p2;
		t3525329789  L_14;
		memset(&L_14, 0, sizeof(L_14));
		m2926210380(&L_14, ((float)((float)L_2+(float)((float)((float)((float)((float)L_3-(float)L_4))*(float)L_5)))), ((float)((float)L_6+(float)((float)((float)((float)((float)L_7-(float)L_8))*(float)L_9)))), ((float)((float)L_10+(float)((float)((float)((float)((float)L_11-(float)L_12))*(float)L_13)))), NULL);
		return L_14;
	}
}
extern TypeInfo* t3760259642_TI_var;
extern Il2CppCodeGenString* _stringLiteral965278184;
extern const uint32_t m108333500_MetadataUsageId;
extern "C"  float m108333500 (t3525329789 * __this, int32_t p0, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m108333500_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	int32_t V_0 = 0;
	{
		int32_t L_0 = p0;
		V_0 = L_0;
		int32_t L_1 = V_0;
		if (L_1 == 0)
		{
			goto IL_0019;
		}
		if (L_1 == 1)
		{
			goto IL_0020;
		}
		if (L_1 == 2)
		{
			goto IL_0027;
		}
	}
	{
		goto IL_002e;
	}

IL_0019:
	{
		float L_2 = __this->fg1();
		return L_2;
	}

IL_0020:
	{
		float L_3 = __this->fg2();
		return L_3;
	}

IL_0027:
	{
		float L_4 = __this->fg3();
		return L_4;
	}

IL_002e:
	{
		t3760259642 * L_5 = (t3760259642 *)il2cpp_codegen_object_new(t3760259642_TI_var);
		m1621772274(L_5, _stringLiteral965278184, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5);
	}
}
extern TypeInfo* t3760259642_TI_var;
extern Il2CppCodeGenString* _stringLiteral965278184;
extern const uint32_t m1844835745_MetadataUsageId;
extern "C"  void m1844835745 (t3525329789 * __this, int32_t p0, float p1, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m1844835745_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	int32_t V_0 = 0;
	{
		int32_t L_0 = p0;
		V_0 = L_0;
		int32_t L_1 = V_0;
		if (L_1 == 0)
		{
			goto IL_0019;
		}
		if (L_1 == 1)
		{
			goto IL_0025;
		}
		if (L_1 == 2)
		{
			goto IL_0031;
		}
	}
	{
		goto IL_003d;
	}

IL_0019:
	{
		float L_2 = p1;
		__this->fs1(L_2);
		goto IL_0048;
	}

IL_0025:
	{
		float L_3 = p1;
		__this->fs2(L_3);
		goto IL_0048;
	}

IL_0031:
	{
		float L_4 = p1;
		__this->fs3(L_4);
		goto IL_0048;
	}

IL_003d:
	{
		t3760259642 * L_5 = (t3760259642 *)il2cpp_codegen_object_new(t3760259642_TI_var);
		m1621772274(L_5, _stringLiteral965278184, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5);
	}

IL_0048:
	{
		return;
	}
}
extern "C"  t3525329789  m2894122475 (Il2CppObject * __this , t3525329789  p0, t3525329789  p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg2();
		float L_1 = (&p1)->fg3();
		float L_2 = (&p0)->fg3();
		float L_3 = (&p1)->fg2();
		float L_4 = (&p0)->fg3();
		float L_5 = (&p1)->fg1();
		float L_6 = (&p0)->fg1();
		float L_7 = (&p1)->fg3();
		float L_8 = (&p0)->fg1();
		float L_9 = (&p1)->fg2();
		float L_10 = (&p0)->fg2();
		float L_11 = (&p1)->fg1();
		t3525329789  L_12;
		memset(&L_12, 0, sizeof(L_12));
		m2926210380(&L_12, ((float)((float)((float)((float)L_0*(float)L_1))-(float)((float)((float)L_2*(float)L_3)))), ((float)((float)((float)((float)L_4*(float)L_5))-(float)((float)((float)L_6*(float)L_7)))), ((float)((float)((float)((float)L_8*(float)L_9))-(float)((float)((float)L_10*(float)L_11)))), NULL);
		return L_12;
	}
}
extern "C"  int32_t m3912867704 (t3525329789 * __this, const MethodInfo* method)
{
	{
		float* L_0 = __this->fag1();
		int32_t L_1 = m65342520(L_0, NULL);
		float* L_2 = __this->fag2();
		int32_t L_3 = m65342520(L_2, NULL);
		float* L_4 = __this->fag3();
		int32_t L_5 = m65342520(L_4, NULL);
		return ((int32_t)((int32_t)((int32_t)((int32_t)L_1^(int32_t)((int32_t)((int32_t)L_3<<(int32_t)2))))^(int32_t)((int32_t)((int32_t)L_5>>(int32_t)2))));
	}
}
extern TypeInfo* t3525329789_TI_var;
extern const uint32_t m3337192096_MetadataUsageId;
extern "C"  bool m3337192096 (t3525329789 * __this, Il2CppObject * p0, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m3337192096_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	t3525329789  V_0;
	memset(&V_0, 0, sizeof(V_0));
	int32_t G_B6_0 = 0;
	{
		Il2CppObject * L_0 = p0;
		if (((Il2CppObject *)IsInstSealed(L_0, t3525329789_TI_var)))
		{
			goto IL_000d;
		}
	}
	{
		return (bool)0;
	}

IL_000d:
	{
		Il2CppObject * L_1 = p0;
		V_0 = ((*(t3525329789 *)((t3525329789 *)UnBox (L_1, t3525329789_TI_var))));
		float* L_2 = __this->fag1();
		float L_3 = (&V_0)->fg1();
		bool L_4 = m2110115959(L_2, L_3, NULL);
		if (!L_4)
		{
			goto IL_0056;
		}
	}
	{
		float* L_5 = __this->fag2();
		float L_6 = (&V_0)->fg2();
		bool L_7 = m2110115959(L_5, L_6, NULL);
		if (!L_7)
		{
			goto IL_0056;
		}
	}
	{
		float* L_8 = __this->fag3();
		float L_9 = (&V_0)->fg3();
		bool L_10 = m2110115959(L_8, L_9, NULL);
		G_B6_0 = ((int32_t)(L_10));
		goto IL_0057;
	}

IL_0056:
	{
		G_B6_0 = 0;
	}

IL_0057:
	{
		return (bool)G_B6_0;
	}
}
extern "C"  t3525329789  m3047997355 (Il2CppObject * __this , t3525329789  p0, const MethodInfo* method)
{
	float V_0 = 0.0f;
	{
		t3525329789  L_0 = p0;
		float L_1 = m995314358(NULL, L_0, NULL);
		V_0 = L_1;
		float L_2 = V_0;
		if ((!(((float)L_2) > ((float)(1.0E-05f)))))
		{
			goto IL_001a;
		}
	}
	{
		t3525329789  L_3 = p0;
		float L_4 = V_0;
		t3525329789  L_5 = m4277988370(NULL, L_3, L_4, NULL);
		return L_5;
	}

IL_001a:
	{
		t3525329789  L_6 = m2017759730(NULL, NULL);
		return L_6;
	}
}
extern "C"  t3525329789  m2650940353 (t3525329789 * __this, const MethodInfo* method)
{
	{
		t3525329789  L_0 = m3047997355(NULL, (*(t3525329789 *)__this), NULL);
		return L_0;
	}
}
extern TypeInfo* t11523773_TI_var;
extern TypeInfo* t958209021_TI_var;
extern Il2CppCodeGenString* _stringLiteral1732534255;
extern const uint32_t m3566373060_MetadataUsageId;
extern "C"  String_t* m3566373060 (t3525329789 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m3566373060_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		t11523773* L_0 = ((t11523773*)SZArrayNew(t11523773_TI_var, (uint32_t)3));
		float L_1 = __this->fg1();
		float L_2 = L_1;
		Il2CppObject * L_3 = Box(t958209021_TI_var, &L_2);
		ArrayElementTypeCheck (L_0, L_3);
		(L_0)->SetAt(static_cast<il2cpp_array_size_t>(0), (Il2CppObject *)L_3);
		t11523773* L_4 = L_0;
		float L_5 = __this->fg2();
		float L_6 = L_5;
		Il2CppObject * L_7 = Box(t958209021_TI_var, &L_6);
		ArrayElementTypeCheck (L_4, L_7);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(1), (Il2CppObject *)L_7);
		t11523773* L_8 = L_4;
		float L_9 = __this->fg3();
		float L_10 = L_9;
		Il2CppObject * L_11 = Box(t958209021_TI_var, &L_10);
		ArrayElementTypeCheck (L_8, L_11);
		(L_8)->SetAt(static_cast<il2cpp_array_size_t>(2), (Il2CppObject *)L_11);
		String_t* L_12 = m427603113(NULL, _stringLiteral1732534255, L_8, NULL);
		return L_12;
	}
}
extern "C"  float m2370485424 (Il2CppObject * __this , t3525329789  p0, t3525329789  p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p1)->fg1();
		float L_2 = (&p0)->fg2();
		float L_3 = (&p1)->fg2();
		float L_4 = (&p0)->fg3();
		float L_5 = (&p1)->fg3();
		return ((float)((float)((float)((float)((float)((float)L_0*(float)L_1))+(float)((float)((float)L_2*(float)L_3))))+(float)((float)((float)L_4*(float)L_5))));
	}
}
extern TypeInfo* t1597001355_TI_var;
extern const uint32_t m3366690344_MetadataUsageId;
extern "C"  float m3366690344 (Il2CppObject * __this , t3525329789  p0, t3525329789  p1, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m3366690344_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	t3525329789  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p1)->fg1();
		float L_2 = (&p0)->fg2();
		float L_3 = (&p1)->fg2();
		float L_4 = (&p0)->fg3();
		float L_5 = (&p1)->fg3();
		m2926210380((&V_0), ((float)((float)L_0-(float)L_1)), ((float)((float)L_2-(float)L_3)), ((float)((float)L_4-(float)L_5)), NULL);
		float L_6 = (&V_0)->fg1();
		float L_7 = (&V_0)->fg1();
		float L_8 = (&V_0)->fg2();
		float L_9 = (&V_0)->fg2();
		float L_10 = (&V_0)->fg3();
		float L_11 = (&V_0)->fg3();
		IL2CPP_RUNTIME_CLASS_INIT(t1597001355_TI_var);
		float L_12 = sqrtf(((float)((float)((float)((float)((float)((float)L_6*(float)L_7))+(float)((float)((float)L_8*(float)L_9))))+(float)((float)((float)L_10*(float)L_11)))));
		return L_12;
	}
}
extern TypeInfo* t1597001355_TI_var;
extern const uint32_t m995314358_MetadataUsageId;
extern "C"  float m995314358 (Il2CppObject * __this , t3525329789  p0, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m995314358_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p0)->fg1();
		float L_2 = (&p0)->fg2();
		float L_3 = (&p0)->fg2();
		float L_4 = (&p0)->fg3();
		float L_5 = (&p0)->fg3();
		IL2CPP_RUNTIME_CLASS_INIT(t1597001355_TI_var);
		float L_6 = sqrtf(((float)((float)((float)((float)((float)((float)L_0*(float)L_1))+(float)((float)((float)L_2*(float)L_3))))+(float)((float)((float)L_4*(float)L_5)))));
		return L_6;
	}
}
extern "C"  float m1662776270 (Il2CppObject * __this , t3525329789  p0, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p0)->fg1();
		float L_2 = (&p0)->fg2();
		float L_3 = (&p0)->fg2();
		float L_4 = (&p0)->fg3();
		float L_5 = (&p0)->fg3();
		return ((float)((float)((float)((float)((float)((float)L_0*(float)L_1))+(float)((float)((float)L_2*(float)L_3))))+(float)((float)((float)L_4*(float)L_5))));
	}
}
extern "C"  float m1207423764 (t3525329789 * __this, const MethodInfo* method)
{
	{
		float L_0 = __this->fg1();
		float L_1 = __this->fg1();
		float L_2 = __this->fg2();
		float L_3 = __this->fg2();
		float L_4 = __this->fg3();
		float L_5 = __this->fg3();
		return ((float)((float)((float)((float)((float)((float)L_0*(float)L_1))+(float)((float)((float)L_2*(float)L_3))))+(float)((float)((float)L_4*(float)L_5))));
	}
}
extern TypeInfo* t1597001355_TI_var;
extern const uint32_t m10392601_MetadataUsageId;
extern "C"  t3525329789  m10392601 (Il2CppObject * __this , t3525329789  p0, t3525329789  p1, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m10392601_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p1)->fg1();
		IL2CPP_RUNTIME_CLASS_INIT(t1597001355_TI_var);
		float L_2 = m2322067385(NULL, L_0, L_1, NULL);
		float L_3 = (&p0)->fg2();
		float L_4 = (&p1)->fg2();
		float L_5 = m2322067385(NULL, L_3, L_4, NULL);
		float L_6 = (&p0)->fg3();
		float L_7 = (&p1)->fg3();
		float L_8 = m2322067385(NULL, L_6, L_7, NULL);
		t3525329789  L_9;
		memset(&L_9, 0, sizeof(L_9));
		m2926210380(&L_9, L_2, L_5, L_8, NULL);
		return L_9;
	}
}
extern TypeInfo* t1597001355_TI_var;
extern const uint32_t m545730887_MetadataUsageId;
extern "C"  t3525329789  m545730887 (Il2CppObject * __this , t3525329789  p0, t3525329789  p1, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m545730887_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p1)->fg1();
		IL2CPP_RUNTIME_CLASS_INIT(t1597001355_TI_var);
		float L_2 = m3923796455(NULL, L_0, L_1, NULL);
		float L_3 = (&p0)->fg2();
		float L_4 = (&p1)->fg2();
		float L_5 = m3923796455(NULL, L_3, L_4, NULL);
		float L_6 = (&p0)->fg3();
		float L_7 = (&p1)->fg3();
		float L_8 = m3923796455(NULL, L_6, L_7, NULL);
		t3525329789  L_9;
		memset(&L_9, 0, sizeof(L_9));
		m2926210380(&L_9, L_2, L_5, L_8, NULL);
		return L_9;
	}
}
extern "C"  t3525329789  m2017759730 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329789  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m2926210380(&L_0, (0.0f), (0.0f), (0.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329789  m886467710 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329789  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m2926210380(&L_0, (1.0f), (1.0f), (1.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329789  m1039372701 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329789  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m2926210380(&L_0, (0.0f), (0.0f), (1.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329789  m1326515313 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329789  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m2926210380(&L_0, (0.0f), (0.0f), (-1.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329789  m4046647141 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329789  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m2926210380(&L_0, (0.0f), (1.0f), (0.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329789  m1397301612 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329789  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m2926210380(&L_0, (0.0f), (-1.0f), (0.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329789  m1616598929 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329789  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m2926210380(&L_0, (-1.0f), (0.0f), (0.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329789  m4015137012 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329789  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m2926210380(&L_0, (1.0f), (0.0f), (0.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329789  m695438225 (Il2CppObject * __this , t3525329789  p0, t3525329789  p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p1)->fg1();
		float L_2 = (&p0)->fg2();
		float L_3 = (&p1)->fg2();
		float L_4 = (&p0)->fg3();
		float L_5 = (&p1)->fg3();
		t3525329789  L_6;
		memset(&L_6, 0, sizeof(L_6));
		m2926210380(&L_6, ((float)((float)L_0+(float)L_1)), ((float)((float)L_2+(float)L_3)), ((float)((float)L_4+(float)L_5)), NULL);
		return L_6;
	}
}
extern "C"  t3525329789  m2842958165 (Il2CppObject * __this , t3525329789  p0, t3525329789  p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p1)->fg1();
		float L_2 = (&p0)->fg2();
		float L_3 = (&p1)->fg2();
		float L_4 = (&p0)->fg3();
		float L_5 = (&p1)->fg3();
		t3525329789  L_6;
		memset(&L_6, 0, sizeof(L_6));
		m2926210380(&L_6, ((float)((float)L_0-(float)L_1)), ((float)((float)L_2-(float)L_3)), ((float)((float)L_4-(float)L_5)), NULL);
		return L_6;
	}
}
extern "C"  t3525329789  m3293197314 (Il2CppObject * __this , t3525329789  p0, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p0)->fg2();
		float L_2 = (&p0)->fg3();
		t3525329789  L_3;
		memset(&L_3, 0, sizeof(L_3));
		m2926210380(&L_3, ((-L_0)), ((-L_1)), ((-L_2)), NULL);
		return L_3;
	}
}
extern "C"  t3525329789  m973638459 (Il2CppObject * __this , t3525329789  p0, float p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = p1;
		float L_2 = (&p0)->fg2();
		float L_3 = p1;
		float L_4 = (&p0)->fg3();
		float L_5 = p1;
		t3525329789  L_6;
		memset(&L_6, 0, sizeof(L_6));
		m2926210380(&L_6, ((float)((float)L_0*(float)L_1)), ((float)((float)L_2*(float)L_3)), ((float)((float)L_4*(float)L_5)), NULL);
		return L_6;
	}
}
extern "C"  t3525329789  m4277988370 (Il2CppObject * __this , t3525329789  p0, float p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = p1;
		float L_2 = (&p0)->fg2();
		float L_3 = p1;
		float L_4 = (&p0)->fg3();
		float L_5 = p1;
		t3525329789  L_6;
		memset(&L_6, 0, sizeof(L_6));
		m2926210380(&L_6, ((float)((float)L_0/(float)L_1)), ((float)((float)L_2/(float)L_3)), ((float)((float)L_4/(float)L_5)), NULL);
		return L_6;
	}
}
extern "C"  bool m582817895 (Il2CppObject * __this , t3525329789  p0, t3525329789  p1, const MethodInfo* method)
{
	{
		t3525329789  L_0 = p0;
		t3525329789  L_1 = p1;
		t3525329789  L_2 = m2842958165(NULL, L_0, L_1, NULL);
		float L_3 = m1662776270(NULL, L_2, NULL);
		return (bool)((((float)L_3) < ((float)(9.99999944E-11f)))? 1 : 0);
	}
}
extern "C"  bool m231387234 (Il2CppObject * __this , t3525329789  p0, t3525329789  p1, const MethodInfo* method)
{
	{
		t3525329789  L_0 = p0;
		t3525329789  L_1 = p1;
		t3525329789  L_2 = m2842958165(NULL, L_0, L_1, NULL);
		float L_3 = m1662776270(NULL, L_2, NULL);
		return (bool)((((int32_t)((!(((float)L_3) >= ((float)(9.99999944E-11f))))? 1 : 0)) == ((int32_t)0))? 1 : 0);
	}
}
// Conversion methods for marshalling of: UnityEngine.Vector3
extern "C" void t3525329789_marshal(const t3525329789& unmarshaled, t3525329789_marshaled& marshaled)
{
	marshaled.f1 = unmarshaled.fg1();
	marshaled.f2 = unmarshaled.fg2();
	marshaled.f3 = unmarshaled.fg3();
}
extern "C" void t3525329789_marshal_back(const t3525329789_marshaled& marshaled, t3525329789& unmarshaled)
{
	float unmarshaled_x_temp = 0.0f;
	unmarshaled_x_temp = marshaled.f1;
	unmarshaled.fs1(unmarshaled_x_temp);
	float unmarshaled_y_temp = 0.0f;
	unmarshaled_y_temp = marshaled.f2;
	unmarshaled.fs2(unmarshaled_y_temp);
	float unmarshaled_z_temp = 0.0f;
	unmarshaled_z_temp = marshaled.f3;
	unmarshaled.fs3(unmarshaled_z_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.Vector3
extern "C" void t3525329789_marshal_cleanup(t3525329789_marshaled& marshaled)
{
}
extern "C"  void m2441427762 (t3525329790 * __this, float p0, float p1, float p2, float p3, const MethodInfo* method)
{
	{
		float L_0 = p0;
		__this->fs1(L_0);
		float L_1 = p1;
		__this->fs2(L_1);
		float L_2 = p2;
		__this->fs3(L_2);
		float L_3 = p3;
		__this->fs4(L_3);
		return;
	}
}
extern TypeInfo* t3760259642_TI_var;
extern Il2CppCodeGenString* _stringLiteral2708088519;
extern const uint32_t m2326091453_MetadataUsageId;
extern "C"  float m2326091453 (t3525329790 * __this, int32_t p0, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m2326091453_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	int32_t V_0 = 0;
	{
		int32_t L_0 = p0;
		V_0 = L_0;
		int32_t L_1 = V_0;
		if (L_1 == 0)
		{
			goto IL_001d;
		}
		if (L_1 == 1)
		{
			goto IL_0024;
		}
		if (L_1 == 2)
		{
			goto IL_002b;
		}
		if (L_1 == 3)
		{
			goto IL_0032;
		}
	}
	{
		goto IL_0039;
	}

IL_001d:
	{
		float L_2 = __this->fg1();
		return L_2;
	}

IL_0024:
	{
		float L_3 = __this->fg2();
		return L_3;
	}

IL_002b:
	{
		float L_4 = __this->fg3();
		return L_4;
	}

IL_0032:
	{
		float L_5 = __this->fg4();
		return L_5;
	}

IL_0039:
	{
		t3760259642 * L_6 = (t3760259642 *)il2cpp_codegen_object_new(t3760259642_TI_var);
		m1621772274(L_6, _stringLiteral2708088519, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_6);
	}
}
extern TypeInfo* t3760259642_TI_var;
extern Il2CppCodeGenString* _stringLiteral2708088519;
extern const uint32_t m922152162_MetadataUsageId;
extern "C"  void m922152162 (t3525329790 * __this, int32_t p0, float p1, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m922152162_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	int32_t V_0 = 0;
	{
		int32_t L_0 = p0;
		V_0 = L_0;
		int32_t L_1 = V_0;
		if (L_1 == 0)
		{
			goto IL_001d;
		}
		if (L_1 == 1)
		{
			goto IL_0029;
		}
		if (L_1 == 2)
		{
			goto IL_0035;
		}
		if (L_1 == 3)
		{
			goto IL_0041;
		}
	}
	{
		goto IL_004d;
	}

IL_001d:
	{
		float L_2 = p1;
		__this->fs1(L_2);
		goto IL_0058;
	}

IL_0029:
	{
		float L_3 = p1;
		__this->fs2(L_3);
		goto IL_0058;
	}

IL_0035:
	{
		float L_4 = p1;
		__this->fs3(L_4);
		goto IL_0058;
	}

IL_0041:
	{
		float L_5 = p1;
		__this->fs4(L_5);
		goto IL_0058;
	}

IL_004d:
	{
		t3760259642 * L_6 = (t3760259642 *)il2cpp_codegen_object_new(t3760259642_TI_var);
		m1621772274(L_6, _stringLiteral2708088519, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_6);
	}

IL_0058:
	{
		return;
	}
}
extern "C"  int32_t m3402333527 (t3525329790 * __this, const MethodInfo* method)
{
	{
		float* L_0 = __this->fag1();
		int32_t L_1 = m65342520(L_0, NULL);
		float* L_2 = __this->fag2();
		int32_t L_3 = m65342520(L_2, NULL);
		float* L_4 = __this->fag3();
		int32_t L_5 = m65342520(L_4, NULL);
		float* L_6 = __this->fag4();
		int32_t L_7 = m65342520(L_6, NULL);
		return ((int32_t)((int32_t)((int32_t)((int32_t)((int32_t)((int32_t)L_1^(int32_t)((int32_t)((int32_t)L_3<<(int32_t)2))))^(int32_t)((int32_t)((int32_t)L_5>>(int32_t)2))))^(int32_t)((int32_t)((int32_t)L_7>>(int32_t)1))));
	}
}
extern TypeInfo* t3525329790_TI_var;
extern const uint32_t m3270185343_MetadataUsageId;
extern "C"  bool m3270185343 (t3525329790 * __this, Il2CppObject * p0, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m3270185343_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	t3525329790  V_0;
	memset(&V_0, 0, sizeof(V_0));
	int32_t G_B7_0 = 0;
	{
		Il2CppObject * L_0 = p0;
		if (((Il2CppObject *)IsInstSealed(L_0, t3525329790_TI_var)))
		{
			goto IL_000d;
		}
	}
	{
		return (bool)0;
	}

IL_000d:
	{
		Il2CppObject * L_1 = p0;
		V_0 = ((*(t3525329790 *)((t3525329790 *)UnBox (L_1, t3525329790_TI_var))));
		float* L_2 = __this->fag1();
		float L_3 = (&V_0)->fg1();
		bool L_4 = m2110115959(L_2, L_3, NULL);
		if (!L_4)
		{
			goto IL_006d;
		}
	}
	{
		float* L_5 = __this->fag2();
		float L_6 = (&V_0)->fg2();
		bool L_7 = m2110115959(L_5, L_6, NULL);
		if (!L_7)
		{
			goto IL_006d;
		}
	}
	{
		float* L_8 = __this->fag3();
		float L_9 = (&V_0)->fg3();
		bool L_10 = m2110115959(L_8, L_9, NULL);
		if (!L_10)
		{
			goto IL_006d;
		}
	}
	{
		float* L_11 = __this->fag4();
		float L_12 = (&V_0)->fg4();
		bool L_13 = m2110115959(L_11, L_12, NULL);
		G_B7_0 = ((int32_t)(L_13));
		goto IL_006e;
	}

IL_006d:
	{
		G_B7_0 = 0;
	}

IL_006e:
	{
		return (bool)G_B7_0;
	}
}
extern TypeInfo* t11523773_TI_var;
extern TypeInfo* t958209021_TI_var;
extern Il2CppCodeGenString* _stringLiteral843281963;
extern const uint32_t m3272970053_MetadataUsageId;
extern "C"  String_t* m3272970053 (t3525329790 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m3272970053_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		t11523773* L_0 = ((t11523773*)SZArrayNew(t11523773_TI_var, (uint32_t)4));
		float L_1 = __this->fg1();
		float L_2 = L_1;
		Il2CppObject * L_3 = Box(t958209021_TI_var, &L_2);
		ArrayElementTypeCheck (L_0, L_3);
		(L_0)->SetAt(static_cast<il2cpp_array_size_t>(0), (Il2CppObject *)L_3);
		t11523773* L_4 = L_0;
		float L_5 = __this->fg2();
		float L_6 = L_5;
		Il2CppObject * L_7 = Box(t958209021_TI_var, &L_6);
		ArrayElementTypeCheck (L_4, L_7);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(1), (Il2CppObject *)L_7);
		t11523773* L_8 = L_4;
		float L_9 = __this->fg3();
		float L_10 = L_9;
		Il2CppObject * L_11 = Box(t958209021_TI_var, &L_10);
		ArrayElementTypeCheck (L_8, L_11);
		(L_8)->SetAt(static_cast<il2cpp_array_size_t>(2), (Il2CppObject *)L_11);
		t11523773* L_12 = L_8;
		float L_13 = __this->fg4();
		float L_14 = L_13;
		Il2CppObject * L_15 = Box(t958209021_TI_var, &L_14);
		ArrayElementTypeCheck (L_12, L_15);
		(L_12)->SetAt(static_cast<il2cpp_array_size_t>(3), (Il2CppObject *)L_15);
		String_t* L_16 = m427603113(NULL, _stringLiteral843281963, L_12, NULL);
		return L_16;
	}
}
extern "C"  float m2303368623 (Il2CppObject * __this , t3525329790  p0, t3525329790  p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = (&p1)->fg1();
		float L_2 = (&p0)->fg2();
		float L_3 = (&p1)->fg2();
		float L_4 = (&p0)->fg3();
		float L_5 = (&p1)->fg3();
		float L_6 = (&p0)->fg4();
		float L_7 = (&p1)->fg4();
		return ((float)((float)((float)((float)((float)((float)((float)((float)L_0*(float)L_1))+(float)((float)((float)L_2*(float)L_3))))+(float)((float)((float)L_4*(float)L_5))))+(float)((float)((float)L_6*(float)L_7))));
	}
}
extern "C"  float m1418774677 (t3525329790 * __this, const MethodInfo* method)
{
	{
		float L_0 = m2303368623(NULL, (*(t3525329790 *)__this), (*(t3525329790 *)__this), NULL);
		return L_0;
	}
}
extern "C"  t3525329790  m3835647092 (Il2CppObject * __this , const MethodInfo* method)
{
	{
		t3525329790  L_0;
		memset(&L_0, 0, sizeof(L_0));
		m2441427762(&L_0, (0.0f), (0.0f), (0.0f), (0.0f), NULL);
		return L_0;
	}
}
extern "C"  t3525329790  m3513381747 (Il2CppObject * __this , t3525329790  p0, float p1, const MethodInfo* method)
{
	{
		float L_0 = (&p0)->fg1();
		float L_1 = p1;
		float L_2 = (&p0)->fg2();
		float L_3 = p1;
		float L_4 = (&p0)->fg3();
		float L_5 = p1;
		float L_6 = (&p0)->fg4();
		float L_7 = p1;
		t3525329790  L_8;
		memset(&L_8, 0, sizeof(L_8));
		m2441427762(&L_8, ((float)((float)L_0/(float)L_1)), ((float)((float)L_2/(float)L_3)), ((float)((float)L_4/(float)L_5)), ((float)((float)L_6/(float)L_7)), NULL);
		return L_8;
	}
}
// Conversion methods for marshalling of: UnityEngine.Vector4
extern "C" void t3525329790_marshal(const t3525329790& unmarshaled, t3525329790_marshaled& marshaled)
{
	marshaled.f1 = unmarshaled.fg1();
	marshaled.f2 = unmarshaled.fg2();
	marshaled.f3 = unmarshaled.fg3();
	marshaled.f4 = unmarshaled.fg4();
}
extern "C" void t3525329790_marshal_back(const t3525329790_marshaled& marshaled, t3525329790& unmarshaled)
{
	float unmarshaled_x_temp = 0.0f;
	unmarshaled_x_temp = marshaled.f1;
	unmarshaled.fs1(unmarshaled_x_temp);
	float unmarshaled_y_temp = 0.0f;
	unmarshaled_y_temp = marshaled.f2;
	unmarshaled.fs2(unmarshaled_y_temp);
	float unmarshaled_z_temp = 0.0f;
	unmarshaled_z_temp = marshaled.f3;
	unmarshaled.fs3(unmarshaled_z_temp);
	float unmarshaled_w_temp = 0.0f;
	unmarshaled_w_temp = marshaled.f4;
	unmarshaled.fs4(unmarshaled_w_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.Vector4
extern "C" void t3525329790_marshal_cleanup(t3525329790_marshaled& marshaled)
{
}
extern "C"  void m4124201226 (t1917318876 * __this, const MethodInfo* method)
{
	{
		m539393484(__this, NULL);
		return;
	}
}
extern "C"  void m2916734308 (t896427542 * __this, const MethodInfo* method)
{
	{
		m539393484(__this, NULL);
		return;
	}
}
extern "C"  void m3184996201 (t1291133240 * __this, float p0, const MethodInfo* method)
{
	{
		m539393484(__this, NULL);
		float L_0 = p0;
		__this->fs0(L_0);
		return;
	}
}
// Conversion methods for marshalling of: UnityEngine.WaitForSeconds
extern "C" void t1291133240_marshal(const t1291133240& unmarshaled, t1291133240_marshaled& marshaled)
{
	marshaled.f0 = unmarshaled.fg0();
}
extern "C" void t1291133240_marshal_back(const t1291133240_marshaled& marshaled, t1291133240& unmarshaled)
{
	float unmarshaled_m_Seconds_temp = 0.0f;
	unmarshaled_m_Seconds_temp = marshaled.f0;
	unmarshaled.fs0(unmarshaled_m_Seconds_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.WaitForSeconds
extern "C" void t1291133240_marshal_cleanup(t1291133240_marshaled& marshaled)
{
}
extern "C"  void m1888400594 (t4003675496 * __this, const MethodInfo* method)
{
	{
		m2985353781(__this, NULL);
		return;
	}
}
extern "C"  void m2205809533 (t1716006665 * __this, const MethodInfo* method)
{
	{
		m2985353781(__this, NULL);
		return;
	}
}
extern "C"  void m539393484 (t3557331758 * __this, const MethodInfo* method)
{
	{
		m1772956182(__this, NULL);
		return;
	}
}
// Conversion methods for marshalling of: UnityEngine.YieldInstruction
extern "C" void t3557331758_marshal(const t3557331758& unmarshaled, t3557331758_marshaled& marshaled)
{
}
extern "C" void t3557331758_marshal_back(const t3557331758_marshaled& marshaled, t3557331758& unmarshaled)
{
}
// Conversion method for clean up from marshalling of: UnityEngine.YieldInstruction
extern "C" void t3557331758_marshal_cleanup(t3557331758_marshaled& marshaled)
{
}
extern "C"  void m2328546233 (t2344941421 * __this, const MethodInfo* method)
{
	{
		m1821673314(__this, NULL);
		return;
	}
}
extern TypeInfo* t681132919_TI_var;
extern const uint32_t m2600550988_MetadataUsageId;
extern "C"  void m2600550988 (Il2CppObject * __this , const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m2600550988_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		il2cpp_codegen_memory_barrier();
		((t681132919_SFs*)t681132919_TI_var->static_fields)->fs0((1.17549435E-38f));
		il2cpp_codegen_memory_barrier();
		((t681132919_SFs*)t681132919_TI_var->static_fields)->fs1((1.401298E-45f));
		float L_0 = ((t681132919_SFs*)t681132919_TI_var->static_fields)->fg1();
		il2cpp_codegen_memory_barrier();
		float L_1 = m1066672614(NULL, (((t681132919_SFs*)t681132919_TI_var->static_fields)->fag1()), L_0, (0.0f), NULL);
		((t681132919_SFs*)t681132919_TI_var->static_fields)->fs2((bool)((((float)L_1) == ((float)(0.0f)))? 1 : 0));
		return;
	}
}
// Conversion methods for marshalling of: UnityEngineInternal.MathfInternal
extern "C" void t681132919_marshal(const t681132919& unmarshaled, t681132919_marshaled& marshaled)
{
}
extern "C" void t681132919_marshal_back(const t681132919_marshaled& marshaled, t681132919& unmarshaled)
{
}
// Conversion method for clean up from marshalling of: UnityEngineInternal.MathfInternal
extern "C" void t681132919_marshal_cleanup(t681132919_marshaled& marshaled)
{
}
extern "C"  t3660574010 * m3408605866 (Il2CppObject * __this , MethodInfo_t * p0, Type_t * p1, Il2CppObject * p2, const MethodInfo* method)
{
	{
		Type_t * L_0 = p1;
		Il2CppObject * L_1 = p2;
		MethodInfo_t * L_2 = p0;
		t3660574010 * L_3 = m3460497746(NULL, L_0, L_1, L_2, NULL);
		return L_3;
	}
}
extern "C"  MethodInfo_t * m1628849205 (Il2CppObject * __this , t3660574010 * p0, const MethodInfo* method)
{
	{
		t3660574010 * L_0 = p0;
		MethodInfo_t * L_1 = m669548326(L_0, NULL);
		return L_1;
	}
}
extern TypeInfo* t435505844_TI_var;
extern const uint32_t m1168575159_MetadataUsageId;
extern "C"  void m1168575159 (t471424957 * __this, int32_t p0, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (m1168575159_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		int32_t L_0 = p0;
		int32_t L_1 = L_0;
		Il2CppObject * L_2 = Box(t435505844_TI_var, &L_1);
		String_t* L_3 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Enum::ToString() */, (t2778772662 *)L_2);
		m2173394041(__this, L_3, NULL);
		return;
	}
}
extern "C"  void m2173394041 (t471424957 * __this, String_t* p0, const MethodInfo* method)
{
	{
		m2985353781(__this, NULL);
		String_t* L_0 = p0;
		__this->fs0(L_0);
		return;
	}
}
extern "C"  String_t* m318752778 (t471424957 * __this, const MethodInfo* method)
{
	{
		String_t* L_0 = __this->fg0();
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
