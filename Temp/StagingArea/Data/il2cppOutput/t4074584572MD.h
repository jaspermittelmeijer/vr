#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

struct String_t;

#include "codegen/il2cpp-codegen.h"
#include "t4074584572.h"
#include "String_t.h"

extern "C"  void m4205157633 (t4074584572 * __this, String_t* p0, int64_t p1, int32_t p2, const MethodInfo* method) IL2CPP_METHOD_ATTR;

struct t4074584572;
struct t4074584572_marshaled;

extern "C" void t4074584572_marshal(const t4074584572& unmarshaled, t4074584572_marshaled& marshaled);
extern "C" void t4074584572_marshal_back(const t4074584572_marshaled& marshaled, t4074584572& unmarshaled);
extern "C" void t4074584572_marshal_cleanup(t4074584572_marshaled& marshaled);
