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


struct t336011091;
struct t336011091_marshaled;

extern "C" void t336011091_marshal(const t336011091& unmarshaled, t336011091_marshaled& marshaled);
extern "C" void t336011091_marshal_back(const t336011091_marshaled& marshaled, t336011091& unmarshaled);
extern "C" void t336011091_marshal_cleanup(t336011091_marshaled& marshaled);
