﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "t4014882752.h"
#include "IntPtr_t.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1864875887 
{
public:
	IntPtr_t f0;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t1864875887, f0)); }
	inline IntPtr_t fg0() const { return f0; }
	inline IntPtr_t* fag0() { return &f0; }
	inline void set_value_0(IntPtr_t value)
	{
		f0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for marshalling of: System.RuntimeTypeHandle
struct t1864875887_marshaled
{
	intptr_t f0;
};