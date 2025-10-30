// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "ThirdPerson_CPP_TempGameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AThirdPerson_CPP_TempGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AThirdPerson_CPP_TempGameMode();
};



