import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

export default defineConfig({
  plugins: [react()],
  root: "./docs",
  publicDir: "../public", // relative to root dir
  base: "/Feliz.Plotly/",
  build: {
    outDir: "../dist",
    emptyOutDir: true,
  }
})