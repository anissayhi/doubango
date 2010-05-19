
%{
#include "SipUri.h"
#include "SipEvent.h"
#include "SipSession.h"
#include "RegistrationEvent.h"
#include "RegistrationSession.h"
#include "SubscriptionEvent.h"
#include "SubscriptionSession.h"
#include "SipCallback.h"
#include "SafeObject.h"
#include "SipStack.h"
%}

/* turn on director wrapping Callback */
%feature("director") SipCallback;

%nodefaultctor;
%include "SipUri.h"
%include "SipEvent.h"
%include "SipSession.h"
%include "RegistrationEvent.h"
%include "RegistrationSession.h"
%include "SubscriptionEvent.h"
%include "SubscriptionSession.h"
%include "SipCallback.h"
%include "SafeObject.h"
%include "SipStack.h"
%clearnodefaultctor;

/* ====== From "tinySIP\include\tinysip\tsip_event.h"  ====== */
typedef enum tsip_event_type_e
{
	tsip_event_invite,
	tsip_event_message,
	tsip_event_options,
	tsip_event_publish,
	tsip_event_register,
	tsip_event_subscribe,
	
	tsip_event_dialog
}
tsip_event_type_t;

/* ====== From "tinySIP\include\tinysip\tsip_api_register.h"  ====== */
typedef enum tsip_register_event_type_e
{
	tsip_i_register,
	tsip_ai_register,
	tsip_o_register,
	tsip_ao_register,
	
	tsip_i_unregister,
	tsip_ai_unregister,
	tsip_o_unregister,
	tsip_ao_unregister,
}
tsip_register_event_type_t;

/* ====== From "tinySIP\include\tinysip\tsip_api_subscribe.h"  ====== */
typedef enum tsip_subscribe_event_type_e
{
	tsip_i_subscribe,
	tsip_ai_subscribe,
	tsip_o_subscribe,
	tsip_ao_subscribe,
	
	tsip_i_unsubscribe,
	tsip_ai_unsubscribe,
	tsip_o_unsubscribe,
	tsip_ao_unsubscribe,

	tsip_i_notify,
	tsip_ai_notify,
	tsip_o_notify,
	tsip_ao_notify
}
tsip_subscribe_event_type_t;