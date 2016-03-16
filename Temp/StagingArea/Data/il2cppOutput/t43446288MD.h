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


#include "codegen/il2cpp-codegen.h"


struct t43446288;
struct t43446288_marshaled;

extern "C" void t43446288_marshal(const t43446288& unmarshaled, t43446288_marshaled& marshaled);
extern "C" void t43446288_marshal_back(const t43446288_marshaled& marshaled, t43446288& unmarshaled);
extern "C" void t43446288_marshal_cleanup(t43446288_marshaled& marshaled);
