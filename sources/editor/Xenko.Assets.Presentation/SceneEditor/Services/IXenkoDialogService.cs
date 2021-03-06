// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System;
using Xenko.Assets.Presentation.AssetEditors.EntityHierarchyEditor.ViewModels;

namespace Xenko.Assets.Presentation.SceneEditor.Services
{
    /// <summary>
    /// This interface represents Xenko-specifc dialog service.
    /// </summary>
    public interface IXenkoDialogService
    {
        /// <summary>
        /// Creates an entity picker dialog.
        /// </summary>
        /// <param name="editor">The editor view model currently in use.</param>
        /// <returns>An instance of the <see cref="IEntityPickerDialog"/> interface.</returns>
        IEntityPickerDialog CreateEntityPickerDialog(EntityHierarchyEditorViewModel editor);

        /// <summary>
        /// Creates an entity component picker dialog.
        /// </summary>
        /// <param name="editor">The editor view model currently in use.</param>
        /// <param name="componentType">The type of component to pickup.</param>
        /// <returns>An instance of the <see cref="IEntityPickerDialog"/> interface.</returns>
        IEntityPickerDialog CreateEntityComponentPickerDialog(EntityHierarchyEditorViewModel editor, Type componentType);
    }
}
