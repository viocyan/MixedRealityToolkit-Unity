﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace HoloToolkit.Unity.InputModule
{
    /// <summary>
    /// Interface to implement to react to controller input changes.
    /// </summary>
    public interface IControllerInputHandler : IInputHandler
    {
        void OnTriggerPressedValueChanged(TriggerEventData eventData);
        void OnInputPositionChanged(InputPositionEventData eventData);
    }
}