#include "stdafx.h"



QueryFilterCallback::QueryFilterCallback(CapsuleController* controller, OnFilterCallback callBack)
{
	this->controller = controller;
	this->collideCallback = callBack;
}


QueryFilterCallback::~QueryFilterCallback()
{
	this->collideCallback = NULL;
	this->controller = NULL;
}

PxQueryHitType::Enum QueryFilterCallback::preFilter(const PxFilterData& filterData, const PxShape* shape, const PxRigidActor* actor, PxHitFlags& queryFlags)
{
	if(this->collideCallback == NULL)
		return PxQueryHitType::eBLOCK;

	//actor������controller����Ҳ����������controller�������ڸ÷����������controller�Ĺ����߼�����Ч�ģ�
	//��Ҫ��ControllerFilterCallback�д���controller֮�����ײ�����߼�
	ColliderBase* collider = static_cast<ColliderBase*>(actor->userData);
	if (collider->GetType() == (int)ColliderType::Controller)
	{
		return PxQueryHitType::eNONE;
	}

	if (this->collideCallback(this->controller->GetScene(), this->controller->GetActor(), actor))
	{
		return PxQueryHitType::eBLOCK;//������ֹ
	}
	return PxQueryHitType::eNONE;//��������
}

PxQueryHitType::Enum QueryFilterCallback::postFilter(const PxFilterData& filterData, const PxQueryHit& hit)
{
	//����˷�����խ��λ����֮����˿���ʹ�ò��Խ��������PxRaycastHit.position����ȷ���Ƿ�Ӧ�ö�������
	return PxQueryHitType::eNONE;
}