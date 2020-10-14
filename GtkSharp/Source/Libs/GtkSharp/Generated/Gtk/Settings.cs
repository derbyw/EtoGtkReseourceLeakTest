// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Settings : GLib.Object, Gtk.IStyleProvider {

		public Settings (IntPtr raw) : base(raw) {}

		protected Settings() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("gtk-alternative-button-order")]
		public bool AlternativeButtonOrder {
			get {
				GLib.Value val = GetProperty ("gtk-alternative-button-order");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-alternative-button-order", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-alternative-sort-arrows")]
		public bool AlternativeSortArrows {
			get {
				GLib.Value val = GetProperty ("gtk-alternative-sort-arrows");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-alternative-sort-arrows", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-application-prefer-dark-theme")]
		public bool ApplicationPreferDarkTheme {
			get {
				GLib.Value val = GetProperty ("gtk-application-prefer-dark-theme");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-application-prefer-dark-theme", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-auto-mnemonics")]
		public bool AutoMnemonics {
			get {
				GLib.Value val = GetProperty ("gtk-auto-mnemonics");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-auto-mnemonics", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-button-images")]
		public bool ButtonImages {
			get {
				GLib.Value val = GetProperty ("gtk-button-images");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-button-images", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-can-change-accels")]
		public bool CanChangeAccels {
			get {
				GLib.Value val = GetProperty ("gtk-can-change-accels");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-can-change-accels", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-color-palette")]
		public string ColorPalette {
			get {
				GLib.Value val = GetProperty ("gtk-color-palette");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-color-palette", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-color-scheme")]
		public string ColorScheme {
			get {
				GLib.Value val = GetProperty ("gtk-color-scheme");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-color-scheme", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-cursor-blink")]
		public bool CursorBlink {
			get {
				GLib.Value val = GetProperty ("gtk-cursor-blink");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-cursor-blink", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-cursor-blink-time")]
		public int CursorBlinkTime {
			get {
				GLib.Value val = GetProperty ("gtk-cursor-blink-time");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-cursor-blink-time", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-cursor-blink-timeout")]
		public int CursorBlinkTimeout {
			get {
				GLib.Value val = GetProperty ("gtk-cursor-blink-timeout");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-cursor-blink-timeout", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-cursor-theme-name")]
		public string CursorThemeName {
			get {
				GLib.Value val = GetProperty ("gtk-cursor-theme-name");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-cursor-theme-name", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-cursor-theme-size")]
		public int CursorThemeSize {
			get {
				GLib.Value val = GetProperty ("gtk-cursor-theme-size");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-cursor-theme-size", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-dnd-drag-threshold")]
		public int DndDragThreshold {
			get {
				GLib.Value val = GetProperty ("gtk-dnd-drag-threshold");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-dnd-drag-threshold", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-double-click-distance")]
		public int DoubleClickDistance {
			get {
				GLib.Value val = GetProperty ("gtk-double-click-distance");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-double-click-distance", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-double-click-time")]
		public int DoubleClickTime {
			get {
				GLib.Value val = GetProperty ("gtk-double-click-time");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-double-click-time", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-enable-accels")]
		public bool EnableAccels {
			get {
				GLib.Value val = GetProperty ("gtk-enable-accels");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-enable-accels", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-enable-animations")]
		public bool EnableAnimations {
			get {
				GLib.Value val = GetProperty ("gtk-enable-animations");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-enable-animations", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-enable-event-sounds")]
		public bool EnableEventSounds {
			get {
				GLib.Value val = GetProperty ("gtk-enable-event-sounds");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-enable-event-sounds", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-enable-input-feedback-sounds")]
		public bool EnableInputFeedbackSounds {
			get {
				GLib.Value val = GetProperty ("gtk-enable-input-feedback-sounds");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-enable-input-feedback-sounds", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-enable-mnemonics")]
		public bool EnableMnemonics {
			get {
				GLib.Value val = GetProperty ("gtk-enable-mnemonics");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-enable-mnemonics", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-enable-tooltips")]
		public bool EnableTooltips {
			get {
				GLib.Value val = GetProperty ("gtk-enable-tooltips");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-enable-tooltips", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-entry-password-hint-timeout")]
		public uint EntryPasswordHintTimeout {
			get {
				GLib.Value val = GetProperty ("gtk-entry-password-hint-timeout");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-entry-password-hint-timeout", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-entry-select-on-focus")]
		public bool EntrySelectOnFocus {
			get {
				GLib.Value val = GetProperty ("gtk-entry-select-on-focus");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-entry-select-on-focus", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-error-bell")]
		public bool ErrorBell {
			get {
				GLib.Value val = GetProperty ("gtk-error-bell");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-error-bell", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-fallback-icon-theme")]
		public string FallbackIconTheme {
			get {
				GLib.Value val = GetProperty ("gtk-fallback-icon-theme");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-fallback-icon-theme", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-file-chooser-backend")]
		public string FileChooserBackend {
			get {
				GLib.Value val = GetProperty ("gtk-file-chooser-backend");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-file-chooser-backend", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-font-name")]
		public string FontName {
			get {
				GLib.Value val = GetProperty ("gtk-font-name");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-font-name", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-fontconfig-timestamp")]
		public uint FontconfigTimestamp {
			get {
				GLib.Value val = GetProperty ("gtk-fontconfig-timestamp");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-fontconfig-timestamp", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-icon-sizes")]
		public string IconSizes {
			get {
				GLib.Value val = GetProperty ("gtk-icon-sizes");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-icon-sizes", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-icon-theme-name")]
		public string IconThemeName {
			get {
				GLib.Value val = GetProperty ("gtk-icon-theme-name");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-icon-theme-name", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-im-module")]
		public string ImModule {
			get {
				GLib.Value val = GetProperty ("gtk-im-module");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-im-module", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-key-theme-name")]
		public string KeyThemeName {
			get {
				GLib.Value val = GetProperty ("gtk-key-theme-name");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-key-theme-name", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-keynav-cursor-only")]
		public bool KeynavCursorOnly {
			get {
				GLib.Value val = GetProperty ("gtk-keynav-cursor-only");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-keynav-cursor-only", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-keynav-wrap-around")]
		public bool KeynavWrapAround {
			get {
				GLib.Value val = GetProperty ("gtk-keynav-wrap-around");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-keynav-wrap-around", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-label-select-on-focus")]
		public bool LabelSelectOnFocus {
			get {
				GLib.Value val = GetProperty ("gtk-label-select-on-focus");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-label-select-on-focus", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-menu-bar-accel")]
		public string MenuBarAccel {
			get {
				GLib.Value val = GetProperty ("gtk-menu-bar-accel");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-menu-bar-accel", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-menu-bar-popup-delay")]
		public int MenuBarPopupDelay {
			get {
				GLib.Value val = GetProperty ("gtk-menu-bar-popup-delay");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-menu-bar-popup-delay", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-menu-images")]
		public bool MenuImages {
			get {
				GLib.Value val = GetProperty ("gtk-menu-images");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-menu-images", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-menu-popdown-delay")]
		public int MenuPopdownDelay {
			get {
				GLib.Value val = GetProperty ("gtk-menu-popdown-delay");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-menu-popdown-delay", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-menu-popup-delay")]
		public int MenuPopupDelay {
			get {
				GLib.Value val = GetProperty ("gtk-menu-popup-delay");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-menu-popup-delay", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-modules")]
		public string Modules {
			get {
				GLib.Value val = GetProperty ("gtk-modules");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-modules", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-print-backends")]
		public string PrintBackends {
			get {
				GLib.Value val = GetProperty ("gtk-print-backends");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-print-backends", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-print-preview-command")]
		public string PrintPreviewCommand {
			get {
				GLib.Value val = GetProperty ("gtk-print-preview-command");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-print-preview-command", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-recent-files-limit")]
		public int RecentFilesLimit {
			get {
				GLib.Value val = GetProperty ("gtk-recent-files-limit");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-recent-files-limit", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-recent-files-max-age")]
		public int RecentFilesMaxAge {
			get {
				GLib.Value val = GetProperty ("gtk-recent-files-max-age");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-recent-files-max-age", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-scrolled-window-placement")]
		public Gtk.CornerType ScrolledWindowPlacement {
			get {
				GLib.Value val = GetProperty ("gtk-scrolled-window-placement");
				Gtk.CornerType ret = (Gtk.CornerType) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("gtk-scrolled-window-placement", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-show-input-method-menu")]
		public bool ShowInputMethodMenu {
			get {
				GLib.Value val = GetProperty ("gtk-show-input-method-menu");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-show-input-method-menu", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-show-unicode-menu")]
		public bool ShowUnicodeMenu {
			get {
				GLib.Value val = GetProperty ("gtk-show-unicode-menu");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-show-unicode-menu", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-sound-theme-name")]
		public string SoundThemeName {
			get {
				GLib.Value val = GetProperty ("gtk-sound-theme-name");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-sound-theme-name", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-split-cursor")]
		public bool SplitCursor {
			get {
				GLib.Value val = GetProperty ("gtk-split-cursor");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-split-cursor", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-theme-name")]
		public string ThemeName {
			get {
				GLib.Value val = GetProperty ("gtk-theme-name");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-theme-name", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-timeout-expand")]
		public int TimeoutExpand {
			get {
				GLib.Value val = GetProperty ("gtk-timeout-expand");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-timeout-expand", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-timeout-initial")]
		public int TimeoutInitial {
			get {
				GLib.Value val = GetProperty ("gtk-timeout-initial");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-timeout-initial", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-timeout-repeat")]
		public int TimeoutRepeat {
			get {
				GLib.Value val = GetProperty ("gtk-timeout-repeat");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-timeout-repeat", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-toolbar-icon-size")]
		public Gtk.IconSize ToolbarIconSize {
			get {
				GLib.Value val = GetProperty ("gtk-toolbar-icon-size");
				Gtk.IconSize ret = (Gtk.IconSize) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("gtk-toolbar-icon-size", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-toolbar-style")]
		public Gtk.ToolbarStyle ToolbarStyle {
			get {
				GLib.Value val = GetProperty ("gtk-toolbar-style");
				Gtk.ToolbarStyle ret = (Gtk.ToolbarStyle) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("gtk-toolbar-style", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-tooltip-browse-mode-timeout")]
		public int TooltipBrowseModeTimeout {
			get {
				GLib.Value val = GetProperty ("gtk-tooltip-browse-mode-timeout");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-tooltip-browse-mode-timeout", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-tooltip-browse-timeout")]
		public int TooltipBrowseTimeout {
			get {
				GLib.Value val = GetProperty ("gtk-tooltip-browse-timeout");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-tooltip-browse-timeout", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-tooltip-timeout")]
		public int TooltipTimeout {
			get {
				GLib.Value val = GetProperty ("gtk-tooltip-timeout");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-tooltip-timeout", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-touchscreen-mode")]
		public bool TouchscreenMode {
			get {
				GLib.Value val = GetProperty ("gtk-touchscreen-mode");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-touchscreen-mode", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-xft-antialias")]
		public int XftAntialias {
			get {
				GLib.Value val = GetProperty ("gtk-xft-antialias");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-xft-antialias", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-xft-dpi")]
		public int XftDpi {
			get {
				GLib.Value val = GetProperty ("gtk-xft-dpi");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-xft-dpi", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-xft-hinting")]
		public int XftHinting {
			get {
				GLib.Value val = GetProperty ("gtk-xft-hinting");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-xft-hinting", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-xft-hintstyle")]
		public string XftHintstyle {
			get {
				GLib.Value val = GetProperty ("gtk-xft-hintstyle");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-xft-hintstyle", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("gtk-xft-rgba")]
		public string XftRgba {
			get {
				GLib.Value val = GetProperty ("gtk-xft-rgba");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("gtk-xft-rgba", val);
				val.Dispose ();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, null
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_settings_get_default();
		static d_gtk_settings_get_default gtk_settings_get_default = FuncLoader.LoadFunction<d_gtk_settings_get_default>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_settings_get_default"));

		public static Gtk.Settings Default { 
			get {
				IntPtr raw_ret = gtk_settings_get_default();
				Gtk.Settings ret = GLib.Object.GetObject(raw_ret) as Gtk.Settings;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_settings_get_for_screen(IntPtr screen);
		static d_gtk_settings_get_for_screen gtk_settings_get_for_screen = FuncLoader.LoadFunction<d_gtk_settings_get_for_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_settings_get_for_screen"));

		public static Gtk.Settings GetForScreen(Gdk.Screen screen) {
			IntPtr raw_ret = gtk_settings_get_for_screen(screen == null ? IntPtr.Zero : screen.Handle);
			Gtk.Settings ret = GLib.Object.GetObject(raw_ret) as Gtk.Settings;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_settings_get_type();
		static d_gtk_settings_get_type gtk_settings_get_type = FuncLoader.LoadFunction<d_gtk_settings_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_settings_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_settings_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_settings_install_property(IntPtr pspec);
		static d_gtk_settings_install_property gtk_settings_install_property = FuncLoader.LoadFunction<d_gtk_settings_install_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_settings_install_property"));

		[Obsolete]
		public static void InstallProperty(IntPtr pspec) {
			gtk_settings_install_property(pspec);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_settings_install_property_parser(IntPtr pspec, GtkSharp.RcPropertyParserNative parser);
		static d_gtk_settings_install_property_parser gtk_settings_install_property_parser = FuncLoader.LoadFunction<d_gtk_settings_install_property_parser>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_settings_install_property_parser"));

		[Obsolete]
		public static void InstallPropertyParser(IntPtr pspec, Gtk.RcPropertyParser parser) {
			GtkSharp.RcPropertyParserWrapper parser_wrapper = new GtkSharp.RcPropertyParserWrapper (parser);
			gtk_settings_install_property_parser(pspec, parser_wrapper.NativeDelegate);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_settings_reset_property(IntPtr raw, IntPtr name);
		static d_gtk_settings_reset_property gtk_settings_reset_property = FuncLoader.LoadFunction<d_gtk_settings_reset_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_settings_reset_property"));

		public void ResetProperty(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gtk_settings_reset_property(Handle, native_name);
			GLib.Marshaller.Free (native_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_settings_set_double_property(IntPtr raw, IntPtr name, double v_double, IntPtr origin);
		static d_gtk_settings_set_double_property gtk_settings_set_double_property = FuncLoader.LoadFunction<d_gtk_settings_set_double_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_settings_set_double_property"));

		[Obsolete]
		public void SetDoubleProperty(string name, double v_double, string origin) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_origin = GLib.Marshaller.StringToPtrGStrdup (origin);
			gtk_settings_set_double_property(Handle, native_name, v_double, native_origin);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_origin);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_settings_set_long_property(IntPtr raw, IntPtr name, IntPtr v_long, IntPtr origin);
		static d_gtk_settings_set_long_property gtk_settings_set_long_property = FuncLoader.LoadFunction<d_gtk_settings_set_long_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_settings_set_long_property"));

		[Obsolete]
		public void SetLongProperty(string name, long v_long, string origin) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_origin = GLib.Marshaller.StringToPtrGStrdup (origin);
			gtk_settings_set_long_property(Handle, native_name, new IntPtr (v_long), native_origin);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_origin);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_settings_set_property_value(IntPtr raw, IntPtr name, IntPtr svalue);
		static d_gtk_settings_set_property_value gtk_settings_set_property_value = FuncLoader.LoadFunction<d_gtk_settings_set_property_value>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_settings_set_property_value"));

		[Obsolete]
		public void SetPropertyValue(string name, Gtk.SettingsValue svalue) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_svalue = GLib.Marshaller.StructureToPtrAlloc (svalue);
			gtk_settings_set_property_value(Handle, native_name, native_svalue);
			GLib.Marshaller.Free (native_name);
			Marshal.FreeHGlobal (native_svalue);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_settings_set_string_property(IntPtr raw, IntPtr name, IntPtr v_string, IntPtr origin);
		static d_gtk_settings_set_string_property gtk_settings_set_string_property = FuncLoader.LoadFunction<d_gtk_settings_set_string_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_settings_set_string_property"));

		[Obsolete]
		public void SetStringProperty(string name, string v_string, string origin) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_v_string = GLib.Marshaller.StringToPtrGStrdup (v_string);
			IntPtr native_origin = GLib.Marshaller.StringToPtrGStrdup (origin);
			gtk_settings_set_string_property(Handle, native_name, native_v_string, native_origin);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_v_string);
			GLib.Marshaller.Free (native_origin);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_style_provider_get_style_property(IntPtr raw, IntPtr path, int state, IntPtr pspec, IntPtr value);
		static d_gtk_style_provider_get_style_property gtk_style_provider_get_style_property = FuncLoader.LoadFunction<d_gtk_style_provider_get_style_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_provider_get_style_property"));

		public bool GetStyleProperty(Gtk.WidgetPath path, Gtk.StateFlags state, IntPtr pspec, GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			bool raw_ret = gtk_style_provider_get_style_property(Handle, path == null ? IntPtr.Zero : path.Handle, (int) state, pspec, native_value);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
