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


struct t214874614;
struct t214874614_marshaled;

extern "C" void t214874614_marshal(const t214874614& unmarshaled, t214874614_marshaled& marshaled);
extern "C" void t214874614_marshal_back(const t214874614_marshaled& marshaled, t214874614& unmarshaled);
extern "C" void t214874614_marshal_cleanup(t214874614_marshaled& marshaled);
