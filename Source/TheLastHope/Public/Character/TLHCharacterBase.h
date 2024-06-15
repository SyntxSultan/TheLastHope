// Copyright Syntax Games

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"
#include "TLHCharacterBase.generated.h"

UCLASS(Abstract)
class THELASTHOPE_API ATLHCharacterBase : public ACharacter
{
	GENERATED_BODY()

public:
	ATLHCharacterBase();

protected:
	virtual void BeginPlay() override;
};
