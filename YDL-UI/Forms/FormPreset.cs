﻿namespace Maxstupo.YdlUi.Forms {

    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Maxstupo.YdlUi.Settings;
    using Maxstupo.YdlUi.Utility;

    public partial class FormPreset : Form {
        private readonly Preferences preferences;

        public Preset Preset { get; private set; }
        public bool RequestRemoval { get; private set; } = false;
        private bool IsEditMode { get; }

        public FormPreset(Preferences preferences, Preset preset = null) {
            InitializeComponent();
            this.preferences = preferences;

            if (preset != null) {
                Text = $"Edit Download Preset - {preset.Name}";
                btnOkay.Text = "Edit";
                btnOkay.Tag = "okay.edit";
                IsEditMode = true;
                btnDelete.Visible = true;
            } else {
                btnDelete.Visible = false;
                cbDefaultPreset.Checked = !preferences.Presets.Any(p => p.IsDefault);
            }

            txtPresetName.TextChanged += txtPresetName_TextChanged;
            txtPresetName_TextChanged(this, new EventArgs());

            Preset = CreatePreset(preset);



            txtPresetName.DataBindings.Add(nameof(txtPresetName.Text), Preset, nameof(Preset.Name), false, DataSourceUpdateMode.OnPropertyChanged);
            txtUrlMatch.DataBindings.Add(nameof(txtUrlMatch.Text), Preset, nameof(Preset.MatchUrl), false, DataSourceUpdateMode.OnPropertyChanged);
            rbModeSimple.DataBindings.Add(nameof(rbModeSimple.Checked), Preset, nameof(Preset.IsSimpleMode), false, DataSourceUpdateMode.OnPropertyChanged);
            cbDefaultPreset.DataBindings.Add(nameof(cbDefaultPreset.Checked), Preset, nameof(Preset.IsDefault), false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void txtPresetName_TextChanged(object sender, EventArgs e) {
            btnOkay.Enabled = !string.IsNullOrWhiteSpace(txtPresetName.Text) && !txtPresetName.Text.Trim().Equals("(PreviousOptions)", StringComparison.OrdinalIgnoreCase) && (IsEditMode || !preferences.Presets.Any(p => p.Name == txtPresetName.Text));
        }

        private Preset CreatePreset(Preset preset = null) {
            return preset != null ? new Preset(preset) : new Preset(txtPresetName.Text, cbDefaultPreset.Checked) { MatchUrl = txtUrlMatch.Text, IsSimpleMode = rbModeSimple.Checked }; ;
        }

        private void FormPreset_Load(object sender, EventArgs e) {
            BackColor = Color.FromArgb(238, 238, 238);
            panelActions.BackColor = Color.FromArgb(211, 211, 211);

            Localization.ApplyLocaleText(this, toolTip);
            if (IsEditMode) {
                Text = Localization.GetString($"{Tag}.edit", "Edit Download Preset - {PresetName}");
                Text = Text.Replace("{PresetName}", Preset.Name);
            }
        }

        private void btnOkay_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            RequestRemoval = true;
            DialogResult = DialogResult.OK;
        }

    }

}