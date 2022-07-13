// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "BehaviorTree/BTTaskNode.h"
#include "BTT_ChangeAttackState.generated.h"


UCLASS()
class LSH_API UBTT_ChangeAttackState : public UBTTaskNode
{
	GENERATED_BODY()
	
public:
	UBTT_ChangeAttackState();

	virtual EBTNodeResult::Type ExecuteTask(UBehaviorTreeComponent& _ownerComp, uint8* _nodeMemory) override;
};
