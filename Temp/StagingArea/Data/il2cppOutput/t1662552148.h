﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1424601847;
struct t718939805;

#include "Il2CppObject.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1662552148  : public Il2CppObject
{
public:
	Il2CppObject* f0;
	Il2CppObject* f1;
	int32_t f2;
	int32_t f3;
	int32_t f4;
	Il2CppObject* f5;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t1662552148, f0)); }
	inline Il2CppObject* fg0() const { return f0; }
	inline Il2CppObject** fag0() { return &f0; }
	inline void fs0(Il2CppObject* value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t1662552148, f1)); }
	inline Il2CppObject* fg1() const { return f1; }
	inline Il2CppObject** fag1() { return &f1; }
	inline void fs1(Il2CppObject* value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}

	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t1662552148, f2)); }
	inline int32_t fg2() const { return f2; }
	inline int32_t* fag2() { return &f2; }
	inline void fs2(int32_t value)
	{
		f2 = value;
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t1662552148, f3)); }
	inline int32_t fg3() const { return f3; }
	inline int32_t* fag3() { return &f3; }
	inline void fs3(int32_t value)
	{
		f3 = value;
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t1662552148, f4)); }
	inline int32_t fg4() const { return f4; }
	inline int32_t* fag4() { return &f4; }
	inline void fs4(int32_t value)
	{
		f4 = value;
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t1662552148, f5)); }
	inline Il2CppObject* fg5() const { return f5; }
	inline Il2CppObject** fag5() { return &f5; }
	inline void fs5(Il2CppObject* value)
	{
		f5 = value;
		Il2CppCodeGenWriteBarrier(&f5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif