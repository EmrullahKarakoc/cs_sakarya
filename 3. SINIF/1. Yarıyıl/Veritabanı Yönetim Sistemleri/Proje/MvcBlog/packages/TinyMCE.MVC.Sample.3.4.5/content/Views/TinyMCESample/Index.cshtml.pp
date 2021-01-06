@model $rootnamespace$.Models.TinyMCEModel

<h2>Index</h2>

@using (Html.BeginForm()) {

    <fieldset>
        <legend>TinyMCEModel</legend>

        <div class="editor-label">
            @Html.LabelFor(model => model.Content)
        </div>
        <div class="editor-field">
            @Html.EditorFor(model => model.Content)
            @Html.ValidationMessageFor(model => model.Content)
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
}