// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/SaveGame.h"
#include "Project_SLSaveGame.generated.h"

UCLASS()
class LHW_API UProject_SLSaveGame : public USaveGame
{
	GENERATED_BODY()
	
public:
	UProject_SLSaveGame();

public:
	//UPROPERTY() 데코레이터는 가비지 수집기가 개체를 파괴하지 않도록 합니다!

	UPROPERTY()
	FTransform saveCharTransform;
	UPROPERTY()
	float saveCharCurHealthPoint;
	UPROPERTY()
	float saveCharCalHealthPoint;
	UPROPERTY()
	float saveCharCurHealthRecoveryPoint;
	UPROPERTY()
	float saveCharCurUltimatePoint;
	UPROPERTY()
	TArray<int> saveDestroyedMonsterIDArr;
	UPROPERTY()
	TArray<int> saveCampArr;
	UPROPERTY()
	TArray<int> saveDoorArr;
	UPROPERTY()
	TArray<int> saveDestroyItemActorArr;
	UPROPERTY()
	uint8 saveDoorKeyNum;
	UPROPERTY()
	FString mapName;
};
