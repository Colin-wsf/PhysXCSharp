#pragma once

class SceneQuerier
{
public:
	SceneQuerier(PhysicsScene* scene);
	~SceneQuerier();

	static const int MAX_HIT = 20;

	#pragma region Raycast
	PxRaycastBuffer Raycast(PxVec3 origin, PxVec3 direction, PxReal distance);
	RaycastHit* Raycast(PxVec3 origin, PxVec3 direction, PxReal distance, int layerMask);
	int RaycastAll(PxVec3 origin, PxVec3 direction, PxReal distance, RaycastHit* hitArray);
	int RaycastAll(PxVec3 origin, PxVec3 direction, PxReal distance, int layerMask, RaycastHit* hitArray);
	#pragma endregion

	#pragma region SphereCast
	PxSweepBuffer SphereCast(PxVec3 origin, PxVec3 direction, PxReal radius, PxReal distance);
	RaycastHit* SphereCast(PxVec3 origin, PxVec3 direction, PxReal radius, PxReal distance, int layerMask);
	int SphereCastAll(PxVec3 origin, PxVec3 direction, PxReal radius, PxReal distance, RaycastHit* hitArray);
	int SphereCastAll(PxVec3 origin, PxVec3 direction, PxReal radius, PxReal distance, int layerMask, RaycastHit* hitArray);
	#pragma endregion

	#pragma region BoxCast
	PxSweepBuffer BoxCast(PxVec3 origin, PxVec3 direction, PxVec3 halfExtents, PxQuat orientation, PxReal distance);
	RaycastHit* BoxCast(PxVec3 origin, PxVec3 direction, PxVec3 halfExtents, PxQuat orientation, PxReal distance, int layerMask);
	int BoxCastAll(PxVec3 origin, PxVec3 direction, PxVec3 halfExtents, PxQuat orientation, PxReal distance, RaycastHit* hitArray);
	int BoxCastAll(PxVec3 origin, PxVec3 direction, PxVec3 halfExtents, PxQuat orientation, PxReal distance, int layerMask, RaycastHit* hitArray);
	#pragma endregion

	#pragma region CapsuleCast
	PxSweepBuffer CapsuleCast(int axis, PxVec3 origin, PxVec3 direction, PxReal radius, PxReal halfHeight, PxQuat orientation, PxReal distance);
	RaycastHit* CapsuleCast(int axis, PxVec3 origin, PxVec3 direction, PxReal radius, PxReal halfHeight, PxQuat orientation, PxReal distance, int layerMask);
	int CapsuleCastAll(int axis, PxVec3 origin, PxVec3 direction, PxReal radius, PxReal halfHeight, PxQuat orientation, PxReal distance, RaycastHit* hitArray);
	int CapsuleCastAll(int axis, PxVec3 origin, PxVec3 direction, PxReal radius, PxReal halfHeight, PxQuat orientation, PxReal distance, int layerMask, RaycastHit* hitArray);
	#pragma endregion

	RaycastCallback* GetRaycastCallback();

private:
	PhysicsScene* scene;
	RaycastCallback* raycastCallback;
	SweepCastCallback* sweepCallback;
	LayerFilterCallback* layerFilterCallback;
	
	/*
	��������touch hit���� block hit
	*/
	void RaycastAll(PxVec3 origin, PxVec3 direction, PxReal distance, PxRaycastCallback& hitCall);
	/*
	��������touch hit �� block hit����Ҫ�Լ�дblock�жϻص�
	filterCall��hitCall���ִ�У�filterCall ִ�д������̶���hitCall hit����ִ�м���
	������ǰ�ߵ�blockΪ׼�����block��hitCall finalize��Ҫblock����
	*/
	void Raycast(PxVec3 origin, PxVec3 direction, PxReal distance, PxRaycastCallback& hitCall, PxQueryFilterCallback* filterCall);

	/*
	��������touch hit���� block hit
	*/
	void SphereCastAll(PxVec3 origin, PxVec3 direction, PxReal radius, PxReal distance, PxSweepCallback& hitCall);
	void SphereCast(PxVec3 origin, PxVec3 direction, PxReal radius, PxReal distance, PxSweepCallback& hitCall, PxQueryFilterCallback* filterCall);

	/*
	��������touch hit���� block hit
	*/
	void BoxCastAll(PxVec3 origin, PxVec3 direction, PxVec3 halfExtents, PxQuat orientation, PxReal distance, PxSweepCallback& hitCall);
	void BoxCast(PxVec3 origin, PxVec3 direction, PxVec3 halfExtents, PxQuat orientation, PxReal distance, PxSweepCallback& hitCall, PxQueryFilterCallback* filterCall);

	void CapsuleCast(PxVec3 origin, PxVec3 direction, PxReal radius, PxReal halfHeight, PxQuat orientation, PxReal distance, PxSweepCallback& hitCall, PxQueryFilterCallback* filterCall);
	/*
	��������touch hit���� block hit
	*/
	void CapsuleCastAll(PxVec3 origin, PxVec3 direction, PxReal radius, PxReal halfHeight, PxQuat orientation, PxReal distance, PxSweepCallback& hitCall);
	PxQuat& GetQuatByAxis(int axis, PxQuat& rotation);
};

