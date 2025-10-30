// Copyright Epic Games, Inc. All Rights Reserved.


#include "FirstPerson_CPP_TempPlayerController.h"
#include "EnhancedInputSubsystems.h"
#include "Engine/LocalPlayer.h"
#include "InputMappingContext.h"
#include "FirstPerson_CPP_TempCameraManager.h"
#include "Blueprint/UserWidget.h"
#include "FirstPerson_CPP_Temp.h"
#include "Widgets/Input/SVirtualJoystick.h"

AFirstPerson_CPP_TempPlayerController::AFirstPerson_CPP_TempPlayerController()
{
	// set the player camera manager class
	PlayerCameraManagerClass = AFirstPerson_CPP_TempCameraManager::StaticClass();
}

void AFirstPerson_CPP_TempPlayerController::BeginPlay()
{
	Super::BeginPlay();

	
	// only spawn touch controls on local player controllers
	if (SVirtualJoystick::ShouldDisplayTouchInterface() && IsLocalPlayerController())
	{
		// spawn the mobile controls widget
		MobileControlsWidget = CreateWidget<UUserWidget>(this, MobileControlsWidgetClass);

		if (MobileControlsWidget)
		{
			// add the controls to the player screen
			MobileControlsWidget->AddToPlayerScreen(0);

		} else {

			UE_LOG(LogFirstPerson_CPP_Temp, Error, TEXT("Could not spawn mobile controls widget."));

		}

	}
}

void AFirstPerson_CPP_TempPlayerController::SetupInputComponent()
{
	Super::SetupInputComponent();

	// only add IMCs for local player controllers
	if (IsLocalPlayerController())
	{
		// Add Input Mapping Context
		if (UEnhancedInputLocalPlayerSubsystem* Subsystem = ULocalPlayer::GetSubsystem<UEnhancedInputLocalPlayerSubsystem>(GetLocalPlayer()))
		{
			for (UInputMappingContext* CurrentContext : DefaultMappingContexts)
			{
				Subsystem->AddMappingContext(CurrentContext, 0);
			}

			// only add these IMCs if we're not using mobile touch input
			if (!SVirtualJoystick::ShouldDisplayTouchInterface())
			{
				for (UInputMappingContext* CurrentContext : MobileExcludedMappingContexts)
				{
					Subsystem->AddMappingContext(CurrentContext, 0);
				}
			}
		}
	}
	
}
