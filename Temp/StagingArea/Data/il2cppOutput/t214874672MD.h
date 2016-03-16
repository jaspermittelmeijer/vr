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


struct t214874672;
struct t214874672_marshaled;

extern "C" void t214874672_marshal(const t214874672& unmarshaled, t214874672_marshaled& marshaled);
extern "C" void t214874672_marshal_back(const t214874672_marshaled& marshaled, t214874672& unmarshaled);
extern "C" void t214874672_marshal_cleanup(t214874672_marshaled& marshaled);
