import tkinter as tk
from tkinter import filedialog, messagebox, ttk
import os
import threading
import subprocess

class SteamManifestInjector(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title(">> SMI for Linux | v2 <<")
        self.geometry("513x482")
        self.configure(bg="black")
        self.resizable(False, False)

        # Titre
        self.label1 = tk.Label(self, text="Steam Manifest Injector",
                               font=("Segoe UI", 18, "bold"), fg="#FF8000", bg="black")
        self.label1.pack(pady=10)

        self.label2 = tk.Label(self, text="Linux Edition ( Saysaa )",
                               font=("Segoe UI", 10, "bold"), fg="#FFFFFF", bg="black")
        self.label2.pack(pady=5)

        # Boutons
        self.open_button = tk.Button(self, text="- Open Steam -", bg="#80FF80", command=self.open_steam)
        self.open_button.pack(pady=5)
        
        self.close_button = tk.Button(self, text="- Close Steam -", bg="#FF8080", command=self.close_steam)
        self.close_button.pack(pady=5)

        # Sélection fichiers
        self.select_button = tk.Button(self, text="Select files to inject", bg="#8080FF", command=self.select_files)
        self.select_button.pack(pady=10)

        # Progress bar
        self.progress_var = tk.DoubleVar()
        self.progressbar = ttk.Progressbar(self, variable=self.progress_var, maximum=100, length=400)
        self.progressbar.pack(pady=5)
        
    def copy_file_with_progress(self, src, dst):
        try:
            total_size = os.path.getsize(src)
            copied = 0
            buffer_size = 1024 * 1024

            with open(src, "rb") as fsrc, open(dst, "wb") as fdst:
                while True:
                    buf = fsrc.read(buffer_size)
                    if not buf:
                        break
                    fdst.write(buf)
                    copied += len(buf)
                    percent = (copied / total_size) * 100
                    self.progress_var.set(percent)
        except Exception as e:
            messagebox.showerror("Error", f"Error copying file: {e}")
        else:
            messagebox.showinfo("Success", "File Injected")

    def select_files(self):
        files = filedialog.askopenfilenames(title="Select .acf or .manifest files")
        if not files:
            return

        dest_path = os.path.expanduser("~/.steam/steam/steamapps")
        os.makedirs(dest_path, exist_ok=True)

        for file in files:
            ext = os.path.splitext(file)[1].lower()
            dst_file = os.path.join(dest_path, os.path.basename(file))
            if ext in [".acf", ".manifest"]:
                threading.Thread(target=self.copy_file_with_progress, args=(file, dst_file)).start()
            else:
                messagebox.showerror("Error", "The selected file type is not supported.")

    def open_steam(self):
        try:
            subprocess.Popen(["steam"])
        except Exception as e:
            messagebox.showerror("Error", f"Cannot open Steam: {e}")

    def close_steam(self):
        try:
            subprocess.run(["pkill", "steam"])
        except Exception as e:
            messagebox.showerror("Error", f"Cannot close Steam: {e}")


if __name__ == "__main__":
    app = SteamManifestInjector()
    app.mainloop()
