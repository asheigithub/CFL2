# Copyright (C) 2009 The Android Open Source Project
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#      http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#
LOCAL_PATH := $(call my-dir)


include $(CLEAR_VARS)


LOCAL_MODULE    := CFLCommImpl
LOCAL_SRC_FILES :=  ../../../GLES/gl3stub.c \
					$(subst $(LOCAL_PATH)/,, \
					$(wildcard $(LOCAL_PATH)/../*.c)  \
					$(wildcard $(LOCAL_PATH)/../*.cpp) \
					$(wildcard $(LOCAL_PATH)/../../CommSrc/*.cpp))

LOCAL_C_INCLUDES:= ../../GLES \
				   ../../CFLComm/src 				   
				   			   	   
			   
#LOCAL_LDLIBS    := -llog -landroid -lEGL -lGLESv2 


LOCAL_STATIC_LIBRARIES := android_native_app_glue 

#LOCAL_MODULE_FILENAME := CFLCommImpl

include $(BUILD_STATIC_LIBRARY)

$(call import-module,android/native_app_glue)
